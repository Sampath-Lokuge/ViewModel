using ASPViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPViewModel.Repositories
{
    public class ProductRepository
    {
        /// <summary>
        /// to get product category
        /// </summary>
        public ProductCategory GetProductCategory(int categoryId)
        {
            var productCategoryList = GetAllProductCategoriesMockDatas();

            return (from p in productCategoryList
                    where (p.Id == categoryId)
                    select p).FirstOrDefault();
        }

        /// <summary>
        /// to get all product categories
        /// </summary>
        /// <returns></returns>
        public List<ProductCategory> GetAllProductCategories()
        {
            var productCategoryList = GetAllProductCategoriesMockDatas();

            return (from p in productCategoryList
                    select p)
                    .OrderBy(p => p.CategoryName)
                    .ToList();
        }

        /// <summary>
        /// to Get All Product Categories mock datas
        /// </summary>
        private List<ProductCategory> GetAllProductCategoriesMockDatas()
        {
            var productCategoryList = new List<ProductCategory>();

            productCategoryList.Add(new ProductCategory
            {
                Id = 1,
                CategoryName = "Foods",
            });

            productCategoryList.Add(new ProductCategory
            {
                Id = 2,
                CategoryName = "Toys",
            });

            productCategoryList.Add(new ProductCategory
            {
                Id = 3,
                CategoryName = "Mobile Phones",
            });

            return productCategoryList;
        }

    }
}