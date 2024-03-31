using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FactoryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            createFuniture pa = new CreateChair();
            pa.build("Wood", "Pink");

            createFuniture pt = new CreateTable();

            pt.build("Metal ", "BLACK");
        }
    }


public interface iFurniture {
    void Custom(String material, String color);
}

class chair : iFurniture {
    public void Custom(String material, String color) {
        Console.WriteLine($"The Chair is made using \n material : {material}  \n Color : {color}  ");
    } 
}

class table : iFurniture { 

public void Custom(String material, String color) { 
        Console.WriteLine($"The Table is made using \n material : {material}  \n Color : {color}  ");
    }
}

class sofa : iFurniture {
    public void Custom(String material, String color) {
        Console.WriteLine($"The Sofa is made using \n material : {material}  \n Color : {color}  ");
    }
}

abstract class createFuniture {
    public abstract iFurniture CreateStuff();
        public void build(String material, String color) { 
            var myone = CreateStuff();
            myone.Custom(material, color);
        
        }
}
class CreateChair : createFuniture {
    public override iFurniture CreateStuff() { 
    return new chair();
    }
}
    class CreateTable : createFuniture { 
    public override iFurniture CreateStuff(){
        return new table();
        }
    }


}