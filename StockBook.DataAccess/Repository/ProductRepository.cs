﻿using StockBook.DataAccess.Data;
using StockBook.DataAccess.Repository.IRepository;
using StockBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StockBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product!= null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price100 = product.Price100;
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.Author = product.Author;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}
