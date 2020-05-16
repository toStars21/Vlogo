using System;
using System.Collections.Generic;

namespace Vlogo.Suppliers.Contracts.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public string Title { get; set; }
        public Cuisins Cuisin { get; set; }
        public string Description { get; set; }
        public IReadOnlyCollection<string> Ingredients { get; set; }
        public double Mass { get; set; }
        public double Price { get; set; }
    }
}