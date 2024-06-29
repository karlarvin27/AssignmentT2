using AssignmentT2.DataAccess.Data;
using AssignmentT2.DataAccess.Repository.IRepository;
using AssignmentT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentT2.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
