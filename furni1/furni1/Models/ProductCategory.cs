﻿namespace furni1.Models
{
    public class ProductCategory
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
