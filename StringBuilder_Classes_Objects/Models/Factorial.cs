using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Classes_Objects.Models
{
    class Factorial
    {
        public int Number;

        public void calculate(int number)
        {
            this.Number = number;
            int sum = 1;

            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            Console.WriteLine($"Daxil edilen ededin faktoriali {sum} oldu");
        }
    }
}
