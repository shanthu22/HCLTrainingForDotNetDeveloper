using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Square obj1 = new Square(2);
            
           
            //Console.WriteLine("The Parameter of the Square is : " + obj1.CalculateArea());
            //Console.WriteLine( "The Area of Square is : "+ obj1.CalculatePerimeter()) ;

            //Circle obj2 = new Circle(5);
            //Console.WriteLine("The Parameter of the Circle is : " + obj2.CalculateArea()) ;
            //Console.WriteLine("The Area of Circle is : " + obj2.CalculatePerimeter());

            Bank b = new Bank();
            b.SetBalance(10);
            b.GetBalance();
            b.Deposit(6);
            b.GetBalance();
            b.Withdraw(7);
            b.GetBalance();
        }
    }
}


abstract class Shape
{ 
    public abstract double CalculateArea();

    public abstract double  CalculatePerimeter();
    
}

interface Color {
    void baseColor();
}

interface Structure {
    void Material();
}

class Square : Shape, Color {

    
    public double length;
    
    public Square(double length) {
        this.length = length;
    }
    public override double CalculateArea() {
       double  result = length * length;
        return result;
    }

    public override double CalculatePerimeter() {
        double result = length  * 4;
        return result;
    }
   public  void baseColor() { }
}
class Circle : Shape { 
    public double radius;
public Circle(double radius)
    {
        this.radius = radius;

    }
    public override double CalculateArea()
    {
        return radius * radius * 3.14; 
    }
    
    public override double CalculatePerimeter() {
        return 2 * radius * 3.14; 
    }
}


class Bank {
    private double balance; 
    
    public void SetBalance (double balance)
    {
        if (balance > 0) {
            this.balance = balance;
        }
        else
        {
            Console.WriteLine(" SetBalanc Unexpeccted Request");
        }

    }
    public void   GetBalance() {
        Console.WriteLine(balance);
    }

    public void  Deposit(double Difference) {
        if (Difference > 0) { 
        balance = balance + Difference;
        }
        else
        {
            Console.WriteLine("Deposit Unexpeccted Request");
        }

    }
    public void Withdraw(double Difference) {
        if (Difference > 0) {

            balance = balance - Difference;
        }
        else
        {
            Console.WriteLine(" Withdraw Unexpeccted Request");
        }
    }
}