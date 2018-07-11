using DBlatest.Models;
using DBlatest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBlatest.Services
{
    public class AttractionService
    {
        private AttractionRepository repo;

        public AttractionService(AttractionRepository repository)
        {
            this.repo = repository;
        }

        //CRUD

        public void AddAttraction(Attractions attr)
        {
            repo.AddAtraction(attr);
        }

        public List<Attractions> GetAttractions()
        {
            return repo.GetAttractions();
        }
        
        public void UpdateAttraction(Attractions attr)
        {
            repo.UpdateAttraction(attr);
        }

        public void DeleteAttraction(Attractions attr)
        {
            repo.DeleteAttraction(attr);
        }
    }
}
