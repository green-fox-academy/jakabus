using DBGyakMegertes.Models;
using DBGyakMegertes.Repostitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBGyakMegertes.Services
{
    public class AttractionService
    {
        private AttractionRepository repo;

        public AttractionService(AttractionRepository repo)
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
