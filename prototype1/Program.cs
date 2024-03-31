using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Im called : Prototype");
            PrototypeA obj = new PrototypeA("Check it ");
            
            Console.WriteLine(obj.getField());

            var cloneObj = obj.Clone() as PrototypeA;

          
            cloneObj.setField("--Clone--");
            Console.WriteLine("my clone obj is " + cloneObj.getField());

        }
    }

    interface iprototype {
        iprototype Clone();
    }

    class PrototypeA : iprototype
    {
        private string FieldA;

        public PrototypeA(string _FieldA) {
            FieldA=  _FieldA;
        }
        public void setField(string _FieldA) { 
        this.FieldA= _FieldA;
        }

        public string getField() {

            return FieldA;

        }
        public iprototype Clone() { 
        return new PrototypeA(FieldA);
        }


    }

}
