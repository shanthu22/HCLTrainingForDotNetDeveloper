using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Largest Number 
            //float num1, num2;
            //Console.WriteLine("Enter First number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2 = int.Parse(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    Console.WriteLine("------------------");
            //    Console.WriteLine(num1 + " is bigger ");

            //}
            //else if( num1==num2) {
            //    Console.WriteLine("Both Numbers are equal");
            //}
            //else {
            //    Console.WriteLine(num2 + " Is bigger");
            //}
            Car obj1 = new Car();
           
           
            int testingNum = 2; 
            
            obj1.print();
            obj1.change(ref testingNum);
            Console.WriteLine(testingNum);
            
        }

    }

   class Car {
        public Car(){
            Console.WriteLine("Car Class is Called ");
        }
        public void change(ref int x) {
            x = x + 1;
        }

        public void print(string value="default param") {
            Console.WriteLine(value);
        }
    } 
}


