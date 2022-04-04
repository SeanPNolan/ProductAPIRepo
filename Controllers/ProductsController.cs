using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductApplicationFinal.Models;

namespace ProductApplicationFinal.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Pulp Fiction", Category = "Movie", Price = 1 },
            new Product { Id = 2, Name = "Succession", Category = "TV Show", Price = 3.75M },
            new Product { Id = 3, Name = "Red Dead Redemption 2", Category = "Video Game", Price = 16.99M }
        };

        public ProductsController()
        {

        }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
