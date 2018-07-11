using DataBaseGyak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseGyak.Repostitories
{
    public class AttractionsRepository
    {
        private MacrotisOrientationExamContext context;

        public AttractionsRepository(MacrotisOrientationExamContext context)
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
