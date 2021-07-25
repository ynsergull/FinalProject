using DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
             new Product{ProductId=1, ProductName="Elma", CategoryId=1, UnitPrice=5, UnitsInStock=100},
             new Product{ProductId=2, ProductName="Armut", CategoryId=1, UnitPrice=6, UnitsInStock=90},
             new Product{ProductId=3, ProductName="Telefon", CategoryId=2, UnitPrice=500, UnitsInStock=30},
             new Product{ProductId=4, ProductName="Kulaklık", CategoryId=2, UnitPrice=100, UnitsInStock=50},
             new Product{ProductId=5, ProductName="Sandalye", CategoryId=3, UnitPrice=50, UnitsInStock=10},
             new Product{ProductId=6, ProductName="Perde", CategoryId=4, UnitPrice=150, UnitsInStock=20},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Linq
            //Gönderdeiğim ürün id sine sahip listedeki ürünü bul
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GettAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {   
            //Linq
            //Gönderdeiğim ürün id sine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
        }
    }
}
