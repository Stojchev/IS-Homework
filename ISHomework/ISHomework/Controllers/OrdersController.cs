namespace ISHomework.Controllers
{
    using ISServices.Interface;
    using GemBox.Document;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.IO;
    using System.Text;
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public IActionResult Index()
        {
            var orders = this._orderService.GetAllOrders();
            return View(orders);
        }
        public IActionResult Details(Guid orderId)
        {
            var order = this._orderService.GetOrderDetails(orderId);
            return View(order);
        }

        public IActionResult CreateInvoice(Guid orderId) 
        {
            var order = this._orderService.GetOrderDetails(orderId);

            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "TicketsInvoice.docx");
            var document = DocumentModel.Load(templatePath);

            document.Content.Replace("{{OrderNumber}}", order.Id.ToString());
            document.Content.Replace("{{Email}}", order.User.Email);

            StringBuilder sb = new StringBuilder();
            var totalPrice = 0.0;
            foreach (var item in order.TicketsInOrder)
            {
                totalPrice += item.Quantity * item.Ticket.TicketPrice;
                sb.AppendLine(item.Ticket.MovieName + " " + item.Ticket.MovieYear + " with amount: " + item.Quantity + " and price: " + item.Ticket.TicketPrice + "MKD");
            }
            document.Content.Replace("{{TicketList}}", sb.ToString());
            document.Content.Replace("{{TotalPrice}}", totalPrice.ToString() + "MKD");

            var stream = new MemoryStream();

            document.Save(stream, new PdfSaveOptions());

            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "TicketsInvoice.pdf");
        }
    }
}
