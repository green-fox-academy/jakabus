using MatrixCheckerAsd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerAsd.Repositories
{
    public class MatrixRepository
    {
        private MatrixContext Context;

        public MatrixRepository(MatrixContext context)
        {
            this.Context = context;
        }

        //Crud

        public void CreateMatrix(Matrix matrix)
        {
            Context.Matrices.Add(matrix);
            Context.SaveChanges();
        }

        public List<Matrix> ReadMatrices()
        {
            return Context.Matrices.ToList();
        }

        public void UpdateMatrix(Matrix matrix)
        {
            Context.Matrices.Update(matrix);
            Context.SaveChanges();
        }

        public void DeleteMatrix(Matrix matrix)
        {
            Context.Matrices.Remove(matrix);
            Context.SaveChanges();
        }
    }
}
