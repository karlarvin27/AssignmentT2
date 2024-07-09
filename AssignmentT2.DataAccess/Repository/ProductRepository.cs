using AssignmentT2.DataAccess.Data;
using AssignmentT2.DataAccess.Repository.IRepository;
using AssignmentT2.Models;
using AssignmentT2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentT2.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        

        public void Update(Product obj)
        {
            var objFromDb = _db.Services.FirstOrDefault(u=> u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Services = obj.Services;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price5 = obj.Price5;
                objFromDb.Price3 = obj.Price3;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }

            }
        }
    }
}
