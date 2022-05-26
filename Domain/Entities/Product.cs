﻿namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public double Price { get; set; }

    }
}