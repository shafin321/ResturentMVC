using ResturantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.Interface
{
    public interface IResturentService
    {
        IEnumerable<Resturent> GetByName();
        Resturent GetById(int id);
        void Create(Resturent resturent);
        void Update(Resturent resturent);
        void Commit();
    }
}
