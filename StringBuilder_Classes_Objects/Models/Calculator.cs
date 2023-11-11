using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Classes_Objects.Models
{
    class Calculator
    {
        public int firstNum;
        public int secondNum;

        public void calculate(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            Console.WriteLine($"Daxil edilen 1-ci eded {firstNum}, 2-ci eded ise {secondNum} oldu");
            Console.WriteLine("Hesablama emeliyyati ucun operator daxil edin");
            char givenOperator = char.Parse(Console.ReadLine());
            var result = givenOperator switch
            {
                '+' => firstNum+secondNum,
                '-' => firstNum-secondNum,
                '*' => firstNum*secondNum,
                '/' => firstNum/secondNum,
            };
            Console.WriteLine($"Hesablama emeliyyatinin cavabi: {result}");
        }
    }
}
