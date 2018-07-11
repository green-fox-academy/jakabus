using DBGyakMegertes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBGyakMegertes.Repostitories
{
    public class AttractionRepository
    {
        private MacrotisOrientationExamContext context;

        public AttractionRepository(MacrotisOrientationExamContext context)
        {
            this.context = context;
        }

        //CRUD Muveletek

        public List<Attractions> GetAttractions()
        {
            return context.Attractions.ToList();
        }

        public void AddAttraction(Attractions attraction)
        {
            context.Attractions.Add(attraction);
            context.SaveChanges();
        }

        public void UpdateAttraction(Attractions attraction)
        {
            context.Attractions.Update(attraction);
            context.SaveChanges();
        }

        public void DeleteAttraction(Attractions attraction)
        {
            context.Attractions.Remove(attraction);
            context.SaveChanges();
        }
    }
}
