using StockBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
