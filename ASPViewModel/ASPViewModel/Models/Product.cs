

using System;

namespace ASPViewModel.Models
{
    public class Product
    {
        public Product() { Id = Guid.NewGuid(); }
        public Guid Id { get; set; }
        public string ProductName { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}