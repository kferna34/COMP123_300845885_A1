using COMP123_300845885_A2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_300845885_A1
{
    class Program
    {
        /*
        *This is the driver class  == basically where the methods are tested, and given values, to be shown in the Console window
        *@class program
        */
        static void Main(string[] args)
        {
            //Assignment01
            //// this shows a hero having the fight method = true
            //Console.WriteLine();
            //Hero CaptainComp = new Hero("CaptainComp "); // same as displaying says hello as new ("") 
            //CaptainComp.Strength = 10;
            //CaptainComp.Speed = 65;
            //CaptainComp.Health = 100;
            //CaptainComp.Name = "CaptainComp";
            //CaptainComp.Show();
            //CaptainComp.Fight(true);
            //Console.WriteLine();
            //Console.WriteLine("");

            //// this shows fight = false
            //Console.WriteLine();
            //Hero CaptainSeaSharp = new Hero("CaptainSeaSharp "); // same as displaying says hello as new ("") 
            //CaptainSeaSharp.Strength = 2;
            //CaptainSeaSharp.Speed = 15;
            //CaptainSeaSharp.Health = 100;
            //CaptainSeaSharp.Name = "CaptainSeaSharp";
            //CaptainSeaSharp.Show();
            //CaptainSeaSharp.Fight(false);

            //Assignment 02
            SuperHero SuperComp = new SuperHero("Super Comp");
            SuperComp.Show();
            SuperComp.Health = 100;
            SuperComp.Strength = 15;
            SuperComp.Speed = 25;

            SuperComp.Fight(true);



        }
    }
}
