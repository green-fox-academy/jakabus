using DBlatest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBlatest.Repositories
{
    public class AttractionRepository
    {
        private MacrotisOrientationExamContext context;

        public AttractionRepository(MacrotisOrientationExamContext context)
        {
            this.context = context;
        }

        //CRUD

        public void AddAtraction(Attractions attr)
        {
            context.Attractions.Add(attr);
            context.SaveChanges();
        }

        public List<Attractions> GetAttractions()
        {
            return context.Attractions.ToList();
        }

        public Attractions GetAttraction()
        {
            return context.Attractions.FirstOrDefault();
        }

        public void UpdateAttraction(Attractions attr)
        {
            context.Attractions.Update(attr);
            context.SaveChanges();
        }

        public void DeleteAttraction(Attractions attr)
        {
            context.Attractions.Remove(attr);
            context.SaveChanges();
        }
    }
}
