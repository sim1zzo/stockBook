using StockBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockBook.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
