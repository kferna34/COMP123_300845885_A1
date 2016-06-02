using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_300845885_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            // this shows fight = true
            Console.WriteLine();
            Hero CaptainComp = new Hero("CaptainComp "); // same as displaying says hello as new ("") 
            CaptainComp.Strength = 10;
            CaptainComp.Speed = 65;
            CaptainComp.Health = 100;
            CaptainComp.Name = "CaptainComp";
            CaptainComp.Show();
            CaptainComp.Fight(true);
            Console.WriteLine();
            Console.WriteLine("");

            // this shows fight = false
            Console.WriteLine();
            Hero CaptainSeaSharp = new Hero("CaptainSeaSharp "); // same as displaying says hello as new ("") 
            CaptainSeaSharp.Strength = 2;
            CaptainSeaSharp.Speed = 15;
            CaptainSeaSharp.Health = 100;
            CaptainSeaSharp.Name = "CaptainSeaSharp";
            CaptainSeaSharp.Show();
            CaptainSeaSharp.Fight(false);





        }
    }
}
