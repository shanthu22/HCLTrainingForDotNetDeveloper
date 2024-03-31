using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Factory_practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            createCharacter myMage = new createMage();

            var character = myMage.characterFactory();
            Console.WriteLine( character.Abilities());
           
        }
    }




interface iCharacter {
    String Abilities(); 
}

    class Warrior : iCharacter {
        public String Abilities() {
            return "Warrior: A strong character with high attack and defense.";
        }
    }
    class Mage : iCharacter
    {
        public String Abilities()
        {
            return "Mage: A character with powerful magical abilities but lower defense.";
        }

    }
    class Archer : iCharacter {
        public String Abilities() {
            return " Archer: A character with exceptional ranged attack abilities.";
        }

    }
     abstract class createCharacter
    {
        public abstract iCharacter characterFactory();


        public void callMyFactory()
        {
            var character = characterFactory();
            var a = character.Abilities();
            Console.WriteLine(a);
        }
    }

    class createWarrior : createCharacter {

        public override iCharacter characterFactory() { 
        return new Warrior();
        }
    }
    class createMage : createCharacter
    {
        public override iCharacter characterFactory()
        {
            Console.WriteLine("CreateMage Check  ");
            return new Mage();
        }
    }
    class createArcher : createCharacter
    { 
        public override iCharacter characterFactory()
        {
            return new Archer();
        }
    }
}
