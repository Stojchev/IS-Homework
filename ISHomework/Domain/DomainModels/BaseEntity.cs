﻿namespace ISDomain.DomainModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
