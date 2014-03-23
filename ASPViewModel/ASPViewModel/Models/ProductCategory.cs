
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ASPViewModel.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}