using ASPViewModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPViewModel.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "required")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        public int SelectedValue { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        [DisplayName("Product Category")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}