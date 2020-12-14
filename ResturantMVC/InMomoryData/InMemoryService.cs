using ResturantMVC.Interface;
using ResturantMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantMVC.InMomoryData
{
    public class InMemoryService: IResturentService
    {

        private readonly List<Resturent> resturents;
        public InMemoryService()
        {
            resturents = new List<Resturent>();

            resturents.Add(new Resturent { Name = "Moon Thai", Cusine = CusineType.Thai, Location = "Almedal", Id = 1 });
            resturents.Add(new Resturent { Name = "Dominous", Cusine = CusineType.Italian, Location = "Chalmers", Id = 2 });
            resturents.Add(new Resturent { Name = "Tarka", Cusine = CusineType.Indian, Location = "Banani", Id = 3 });
        }

        public int Commit()
        {
            return 0;
        }

        public void Create(Resturent resturent)
        {
            resturents.Add(resturent);
        }

        public IEnumerable<Resturent> GetByName()
        {
            return resturents;
        }

        public Resturent GetById(int id)
        {
            return resturents.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Resturent resturent)
        {
            var resutentToUpdate = resturents.FirstOrDefault(c => c.Id == resturent.Id);
            if(resutentToUpdate != null)
            {
                resutentToUpdate.Name = resturent.Name;
                resutentToUpdate.Location = resturent.Location;
                resutentToUpdate.Cusine = resturent.Cusine;
                    
            }

            
        }

        void IResturentService.Commit()
        {
            throw new NotImplementedException();
        }
    }
}
