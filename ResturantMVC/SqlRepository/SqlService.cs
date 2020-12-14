using ResturantMVC.Data;
using ResturantMVC.Interface;
using ResturantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.SqlRepository
{
   
    public class SqlService : IResturentService
    {
        private readonly ApplicationDbContext _context;
        public SqlService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Create(Resturent resturent)
        {
            _context.Add(resturent);
        }

        public IEnumerable<Resturent> GetByName(string name)
        {
            return from r in _context.Resturents
                   where string.IsNullOrEmpty(name) || r.Name.Contains(name) //r.Name.StartsWith(name) // r.Name ==name
                   orderby r.Name
                   select r;
        }

        public Resturent GetById(int id)
        {
            return _context.Resturents.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Resturent resturent)
        {
            var updateToResturent = _context.Resturents.FirstOrDefault(c => c.Id == resturent.Id);
            if(updateToResturent != null)
            {
                updateToResturent = resturent;
                   
            }

            else
            {
                throw new Exception("Not found");
            }
        }

        
    }
}
