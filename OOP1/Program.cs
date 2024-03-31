using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Player p1= new Player();
            //Console.WriteLine("Enter the runs ");
            //int num = int.Parse(Console.ReadLine());
            //CricketPlayer cp1 = new CricketPlayer("santhujan ", "vijeyakumar", num);
            //int a=cp1.getRating();
            //Console.WriteLine(a);

            //Console.WriteLine("Enter the number of goals");
            //int num2 = int.Parse(Console.ReadLine());
            //FootBallPlayer fp1 = new FootBallPlayer("santhujan ", "vijeyakumar", num2);
            //Console.WriteLine(fp1.getRating());

            Test obj = new Test();
            obj.aaa();
            Console.ReadLine(); 
            obj.aaa();


        }
    }

    class Player {
        public string fname, lname;
        //Default Constructor 
        public Player() {
            Console.WriteLine("Default copnstructor called ");
            fname = " no name ";
            lname = " no name ";
        }

        public Player(string fname, string lname) {
            this.fname = fname;
            this.lname = lname;

        }
        public string GetName() {
            string fullName = fname + "" + lname;
        return fullName;
        }

        public void setName() { }
    }
    class CricketPlayer : Player
    {
        public double averageRuns;
        CricketPlayer() {
            Console.WriteLine("Deafult Cricket Player class called ");


        }
        public CricketPlayer(string fname, string lname, double averageRuns) { 
        this.fname= fname;
        this.lname= lname;
        this.averageRuns = averageRuns;
        }
        public int getRating() {

            if (this.averageRuns > 55)
                return 7;
            else if (this.averageRuns > 50) {
                return 6;
            }
            else if (this.averageRuns>40) {
                return 5; 
            }
            else if (this.averageRuns > 30 ) { 
                return 3; 
            }
            else if (this.averageRuns > 20)
            {
                return 2;
            }
            return 1;

                    }
    }
    class FootBallPlayer : Player {
        public int goals;
       public  FootBallPlayer(string fname, string lname, int goals) {
        this.fname = fname;
        this.lname= lname;  
        this.goals = goals;

        }
        public int getRating() {

            if (this.goals > 20) { return 5; }
            else if (this.goals > 15) { return 4; }
            else if (this.goals > 10) { return 3; }
            else if (this.goals > 5) { return 2; }
            return 1;
        }
    
    }


