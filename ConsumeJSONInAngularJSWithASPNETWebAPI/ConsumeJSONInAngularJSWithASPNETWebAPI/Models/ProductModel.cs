using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Provider;


namespace ConsumeJSONInAngularJSWithASPNETWebAPI.Models
{
    public class ProductModel
    {
        public List<Product> findAll()
        {
         List<Product> result = new List<Product>();
            result.Add(new Product {Id = "p01", Name = "Product 1", Price = 11, Quantity = 2});
            result.Add(new Product { Id = "p02", Name = "Product 2", Price = 23, Quantity = 3});
        return result;
         }

        public Product find(string id)
        {
            return findAll().Single(p => p.Id.Equals(id));
        }
    }
}