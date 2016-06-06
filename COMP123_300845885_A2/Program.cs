using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_300845885_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero SuperComp = new SuperHero("Super Comp");
            SuperComp.Show();
            SuperComp.Health = 100;
            SuperComp.Strength = 15;
            SuperComp.Speed = 25;
            
            SuperComp.Fight(true);
        }
    }
}
