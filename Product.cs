using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperations
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} ,{Name},{Price}";
        }

        public class ProductCRUD
        {
            List<Product> Products;
            public ProductCRUD()
            {
                Products = new List<Product>();
            }


            public void AddProduct(Product prod)
            {
                Products.Add(prod);
            }

            public void ModifyProduct(Product prod)
            {
                for(int i=0; i<Products.Count; i++)
                {
                    if(Products[i].Id == prod.Id)
                    {
                        Products[i].Name= prod.Name;
                        Products[i].Price= prod.Price;
                        break;
                    }
                }
            }

            public void DeleteProduct(int id)
            {
                for(int i=0 ; i<Products.Count; i++)
                {
                    if(Products[i].Id == id)
                    {
                        Products.Remove(Products[i]);
                        break;
                    }
                }
            }

            public List<Product> ProductList()
            {
                return Products;
            }

            public Product GetProductById(int id)
            {
                Product p = new Product();
                foreach(var  item in Products)
                {
                    if(item.Id == id)
                    {
                        p.Id = item.Id;
                        p.Name = item.Name;
                        p.Price = item.Price;
                        break;
                    }
                }
                return p;
            }

        }

    }
}
