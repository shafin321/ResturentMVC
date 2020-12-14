using ResturantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.Interface
{
    public interface IResturentService
    {
        IEnumerable<Resturent> GetByName(string name);
        Resturent GetById(int id);
        void Create(Resturent resturent);
        void Update(Resturent resturent);
        Resturent Delete(int id);
        void Commit();
    }
}
