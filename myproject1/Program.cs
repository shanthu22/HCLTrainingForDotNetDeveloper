using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int num;
            Console.WriteLine("Enter your name ");
            name= Console.ReadLine();
            
            Console.WriteLine(name);

            Console.WriteLine("Enter a number ");
            num= int.Parse(Console.ReadLine());
            Console.WriteLine(num+ num);

            Program.MyDateCheck();


        }

        static string MyDateCheck() {
            Console.WriteLine("Welcome to Date CHeck Method ");
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.Year);

            return "initialTest";
        }
    }
}
