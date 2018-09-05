using NumberManipulator.Repositories;
using System;
using NumberManipulator.Models;
using System.Collections.Generic;
using System.Linq;

namespace NumberManipulator.Services
{
    public class NumberService
    {
        private NumberRepository numRepo;

        public NumberService(NumberRepository numRepo)
        {
            this.numRepo = numRepo;
        }
        
        public void NumberSaver(Result result)
        {
            Number numbers = new Number { };
            if (result.ResultMessage == "You're fine...")
            {
                numbers.Numbers = result.firstnumber + ";" + result.secondnumber + ";"
                + result.thirdnumber + ";" + result.fourthnumber;
            }
            numRepo.CreateNumber(numbers);
        }

        public List<Number> GetNumbers()
        {
            return numRepo.GetNumbers();
        }

        public Result Startpage(Result result)
        {
            result.Numbers = GetNumbers();
            return result;
        }

        public Result Checker(string firstnumber, string secondnumber, string thirdnumber, string fourthnumber)
        {
            Result result = CheckIfNumbers(firstnumber, secondnumber, thirdnumber, fourthnumber);
            
            NumberSaver(result);

            return result;
        }

        public Result CheckIfNumbers(string firstnumber, string secondnumber, string thirdnumber, string fourthnumber)
        {
            Result result = new Result { };

            result.firstnumber = firstnumber;
            result.secondnumber = secondnumber;
            result.thirdnumber = thirdnumber;
            result.fourthnumber = fourthnumber;
            try
            {
                int numfirst = Convert.ToInt32(firstnumber);
                int numsecond = Convert.ToInt32(secondnumber);
                int numbthird = Convert.ToInt32(thirdnumber);
                int numfourth = Convert.ToInt32(fourthnumber);
                result.ResultMessage = "You're fine...";
            }
            catch (Exception)
            {
                result.ResultMessage = "Dont fuck this up next time...";
            }
            return result;
        }

        public Result SumThisShit(int id)
        {
            double sum;
            Number selectedNumber = GetNumbers().Where(i => i.Id == id).First();
            string[] numbersToSumString = selectedNumber.Numbers.Split(";");
            sum = Convert.ToInt32(numbersToSumString[0]) + Convert.ToInt32(numbersToSumString[1]) +
            Convert.ToInt32(numbersToSumString[2]) + Convert.ToInt32(numbersToSumString[3]);
            Result result = new Result
            {
                SumOfNumbers = sum
            };

            return result;
        }

        public Result SquareThisShit(int id)
        {
            Number selectedNumber = GetNumbers().Where(i => i.Id == id).First();
            string[] numbersToSumString = selectedNumber.Numbers.Split(";");
            int firstsquare = Convert.ToInt32(numbersToSumString[0]) * Convert.ToInt32(numbersToSumString[0]);
            int secondsquare = Convert.ToInt32(numbersToSumString[1]) * Convert.ToInt32(numbersToSumString[1]);
            int thirdsquare = Convert.ToInt32(numbersToSumString[2]) * Convert.ToInt32(numbersToSumString[2]);
            int fourthsquare = Convert.ToInt32(numbersToSumString[3]) * Convert.ToInt32(numbersToSumString[3]);


            Result result = new Result
            {
                firstsquare = firstsquare,
                secondsquare = secondsquare,
                thirdsquare = thirdsquare,
                fourthsquare = fourthsquare
            };
            return result;
        }
    }
}
