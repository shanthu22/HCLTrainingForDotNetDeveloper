using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace factoryMetod3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateFood obj = new createPizza();
            var pizzaObj= obj.FoodFactory();
            Console.WriteLine( pizzaObj.Recipie());

        }
    }

     interface iFood {
        String Recipie(); 
    }

    
    class Pizza : iFood {
        public String Recipie()
        {
            return " Pizza: A food order that includes dough, sauce, cheese, and various toppings.";
        }
    }
    class Burger : iFood
    {
        public String Recipie()
        {
            return "Burger: A food order that includes a bun, patty, cheese, lettuce, tomato, and optional toppings. ";
        }
    }

    class Salad : iFood
    {
        public String Recipie() {
            return "Salad: A food order that includes lettuce, tomatoes, cucumbers, carrots, and optional dressing. ";
        }
    }



    //Abstract Class containing Abstract method 

    abstract class CreateFood {
        public abstract iFood FoodFactory();

           }

    class createPizza : CreateFood {
        public override  iFood FoodFactory() { 
        return new Pizza();
        }
    }

    class createBurger : CreateFood {
        public override iFood FoodFactory() {

            return new Burger();
        }
    }

    class createSalad : CreateFood {
        public override iFood FoodFactory()
        {
        return new Salad();
        }
        }



}
