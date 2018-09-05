using OrientationRetakeMatrix.Models;
using OrientationRetakeMatrix.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientationRetakeMatrix.Services
{
    public class MatrixService
    {
        private MatrixRepository mRepo;

        public MatrixService(MatrixRepository mRepo)
        {
            this.mRepo = mRepo;
        }

        public List<Matrices> GetMatrices()
        {
            return mRepo.GetMatrices();
        }

        public Matrices RemoveMatrix(int id)
        {
            Matrices matrix = GetMatrices().Where(x => x.Id == id).First();
            mRepo.RemoveMatrix(matrix);
            Matrices mmatrix = new Matrices { };
            return mmatrix;
        }

        public Matrices UpdateMatrix(Matrices matrix)
        {
            UsableMatrix(matrix);
            mRepo.UpdateMatrix(matrix);
            return matrix;
        }

        public Matrices LoadMatrix(int id)
        {
            Matrices matrix = GetMatrices().Where(x => x.Id == id).FirstOrDefault();
            return matrix;
        }

        public void UsableMatrix(Matrices matrix)
        {
            int sum = 0;
            if (Even(matrix.M1))
            {
                sum = sum + Convert.ToInt32(matrix.M1);
            }
            if (Even(matrix.M2))
            {
                sum = sum + Convert.ToInt32(matrix.M2);
            }
            if (Even(matrix.M3))
            {
                sum = sum + Convert.ToInt32(matrix.M3);
            }
            if (Even(matrix.M4))
            {
                sum = sum + Convert.ToInt32(matrix.M4);
            }
            if (Even(matrix.M5))
            {
                sum = sum + Convert.ToInt32(matrix.M5);
            }
            if (Even(matrix.M6))
            {
                sum = sum + Convert.ToInt32(matrix.M6);
            }
            if (Even(matrix.M7))
            {
                sum = sum + Convert.ToInt32(matrix.M7);
            }
            if (Even(matrix.M8))
            {
                sum = sum + Convert.ToInt32(matrix.M8);
            }
            if (Even(matrix.M9))
            {
                sum = sum + Convert.ToInt32(matrix.M9);
            }
            if (1 < sum && sum < 33)
            {
                matrix.UsableMatrix = true;
            }
            else
            {
                matrix.UsableMatrix = false;
            }
        }

        public bool Even(byte? number)
        {
            return (number % 2 == 0);
        }
    }
}
