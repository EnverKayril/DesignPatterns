using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Concrete;
using RepositoryDesignPattern.DataAccessLayer.Repositories;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.EntityFramework
{

    public class EfProductDal : GenericRepository<Product> , IProductDal
    {
        private readonly AppDbContext _context;
        public EfProductDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}
