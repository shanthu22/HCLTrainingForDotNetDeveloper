using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Createcharactor obj = new createWarrior();
           var mychar=  obj.charactorFactory();
            
            mychar.choosenCharacter();
            Console.WriteLine(mychar.specialization("Tank"));
          

        }
    }


    interface iCharacter {
       string specialization(string skill);
        void choosenCharacter ();
        
    }

    class Warrior : iCharacter
    { public  string CharacterSkill;
       public string  specialization(string skill) {
        this.CharacterSkill = skill;
            return CharacterSkill;
        }

        public void choosenCharacter() {
            Console.WriteLine("A warrior as been created \n Please select yoru specilization");
        }


    }

    class Mage : iCharacter
    {
       public  string CharacterSkill = null;
        public string specialization(string skill)
        {
            CharacterSkill = skill;
            return CharacterSkill;
        }
        public void choosenCharacter()
        {
            Console.WriteLine("A MAGE as been created \n Please select yoru specilization");
        }
    }
    class Archer : iCharacter
    {
        public string CharacterSkill = null;
        public string specialization(string skill)
        {
            CharacterSkill = skill;
            return CharacterSkill;
        }

        public void choosenCharacter()
        {
            Console.WriteLine("A ARCHER as been created \n Please select yoru specilization");
        }
    }


    abstract class Createcharactor {
        public abstract iCharacter charactorFactory();

    }

    class createWarrior : Createcharactor {
        public override iCharacter charactorFactory() { 
        
        return new Warrior(); }
    }
    class createMage : Createcharactor
    {
        public override iCharacter charactorFactory()
        {

            return new Mage();
        }
    }

    class createArcher : Createcharactor
    {
        public override iCharacter charactorFactory()
        {

            return new Archer();
        }
    }
}
