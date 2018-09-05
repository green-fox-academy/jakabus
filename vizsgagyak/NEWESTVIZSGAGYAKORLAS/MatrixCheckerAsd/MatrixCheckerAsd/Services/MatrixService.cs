using MatrixCheckerAsd.Models;
using MatrixCheckerAsd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerAsd.Services
{
    public class MatrixService
    {
        private MatrixRepository matrixRepository;

        public MatrixService(MatrixRepository matrixRepository)
        {
            this.matrixRepository = matrixRepository;
        }

        public List<Matrix> GetMatrices()
        {
            return matrixRepository.ReadMatrices();
        }
        
        public void MatrixSaver(Matrix matrix)
        {
            if (matrix.IsSquare && matrix.IsIncreasing)
            {
                matrix.Date = DateTime.Now;
                matrixRepository.CreateMatrix(matrix);
            }
        }

        public void DeleteMatrix(string matrixAsString)
        {
            Matrix matrix = RawToMatrix(matrixAsString);
            matrix = MatrixConverter(matrix);
            IsMatrixIncreasing(matrix);
            matrixRepository.DeleteMatrix(matrix);
        }

        
        public Matrix RawToMatrix(string soRawData)
        {
            List<string> list = soRawData.Split("\r\n").ToList();
            List<List<string>> listlist = new List<List<string>>();
            foreach (var line in list)
            {
                listlist.Add(line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            return new Matrix
            {
                MatrixAsString = soRawData,
                MatrixAsList = listlist
            };
        }

        public Matrix MatrixChecker(string soRawData)
        {
            Matrix matrix = RawToMatrix(soRawData);
            matrix = MatrixConverter(matrix);
            IsMatrixIncreasing(matrix);
            if (matrix.IsSquare == true)
            {
                matrix = IsMatrixIncreasing(matrix);
            }
            MatrixSaver(matrix);
            return matrix;
        }

        public Matrix MatrixConverter(Matrix matrix)
        {
            Matrix actMatrix = matrix;
            IsMatrixSquare(matrix);
            if (actMatrix.IsSquare)
            {
                int[][] theMatrix = new int[matrix.MatrixAsList.Count][];

                for (int i = 0; i < theMatrix.Length; i++)
                {
                    theMatrix[i] = new int[matrix.MatrixAsList.Count];
                }

                for (int i = 0; i < matrix.MatrixAsList.Count; i++)
                {
                    for (int j = 0; j < matrix.MatrixAsList[i].Count; j++)
                    {
                        theMatrix[i][j] = Convert.ToInt32(matrix.MatrixAsList[i][j]);
                    }
                }
                actMatrix.ResultMessage = "This is a square matrix";
                actMatrix.theMatrix = theMatrix;
                return actMatrix;
            }
            else
            {
                actMatrix.ResultMessage = "This matrix is not a square matrix";
                return actMatrix;
            }
        }

        public Matrix IsMatrixIncreasing(Matrix matrix)
        {
            Matrix actMatrix = matrix;
            int[][] theMatrix = actMatrix.theMatrix;

            for (int i = 0; i < theMatrix.Length; i++)
            {
                for (int j = 0; j < theMatrix[i].Length - 1; j++)
                {
                    if (theMatrix[i][j] > theMatrix[i][j + 1])
                    {
                        actMatrix.IsIncreasing = false;
                        actMatrix.ResultMessage = "This matrix is not increasing";
                    }
                    else
                    {
                        actMatrix.IsIncreasing = true;
                        actMatrix.ResultMessage = "This matrix is a square and increasing matrix";
                    }
                }
            }
            for (int i = 0; i < theMatrix.Length - 1; i++)
            {
                for (int j = 0; j < theMatrix[i].Length; j++)
                {
                    if (theMatrix[i][j] > theMatrix[i + 1][j])
                    {
                        actMatrix.IsIncreasing = false;
                        actMatrix.ResultMessage = "This matrix is not increasing";
                    }
                    else
                    {
                        actMatrix.IsIncreasing = true;
                        actMatrix.ResultMessage = "This matrix is a square and increasing matrix";
                    }
                }
            }
            return actMatrix;
        }

        public void IsMatrixSquare(Matrix matrix)
        {
            matrix.IsSquare = (matrix.MatrixAsList.All(l => l.Count == matrix.MatrixAsList.Count)); 
        }
    }
}
