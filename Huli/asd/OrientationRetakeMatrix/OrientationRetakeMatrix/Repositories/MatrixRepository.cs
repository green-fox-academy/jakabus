using OrientationRetakeMatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientationRetakeMatrix.Repositories
{
    public class MatrixRepository
    {
        private FulvipesOrientationExamRetakeContext context;

        public MatrixRepository(FulvipesOrientationExamRetakeContext context)
        {
            this.context = context;
        }

        public List<Matrices> GetMatrices()
        {
            return context.Matrices.ToList();
        }

        public void UpdateMatrix(Matrices matrix)
        {
            context.Matrices.Update(matrix);
            context.SaveChanges();
        }

        public void RemoveMatrix(Matrices matrix)
        {
            context.Matrices.Remove(matrix);
            context.SaveChanges();
        }
    }
}
