﻿namespace Ahi.ProductService.source.Domain.Entities
{
    public class Product
    {
        public Guid Id;
        public string? Name;
        public string? Description;
        public string? Summary;
        public int CategoryId;
        public DateTime CreatedDate;
        public bool IsActived;
    }
}