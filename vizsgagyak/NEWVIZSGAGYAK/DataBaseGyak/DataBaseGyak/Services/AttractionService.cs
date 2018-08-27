using DataBaseGyak.Models;
using DataBaseGyak.Repostitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseGyak.Services
{
    public class AttractionService
    {
        private AttractionsRepository repo;

        public AttractionService(AttractionsRepository repo)
        {
            this.repo = repo;
        }

        public List<Attractions> GetAttractions()
        {
            return repo.GetAttractions();
        }

        public void AddAttraction(Attractions attraction)
        {
            repo.AddAttraction(attraction);
        }

        public void UpdateAttraction(Attractions attraction)
        {
            repo.UpdateAttraction(attraction);
        }

        public void DeleteAttraction(Attractions attraction)
        {
            repo.DeleteAttraction(attraction);
        }
    }
}
