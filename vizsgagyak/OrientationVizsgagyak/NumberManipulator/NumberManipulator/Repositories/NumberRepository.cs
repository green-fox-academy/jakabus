using NumberManipulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberManipulator.Repositories
{
    public class NumberRepository
    {
        private NumberContext numberContext;

        public NumberRepository(NumberContext numberContext)
        {
            this.numberContext = numberContext;
        }
        
        public void CreateNumber(Number numbers)
        {
            numberContext.Add(numbers);
            numberContext.SaveChanges();
        }

        public List<Number> GetNumbers()
        {
            return numberContext.Numbers.ToList();
        }
    }
}
