using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_300845885_A1;

/*
 * Author : Krytia Fernandez
 * Student Number : 300845885
 * Description:A program taht will implement a sub class (SuperHero.Cs).refering to Assignment one Making the Hero Class from Assignment 01 the super class Hero.cs
 * Version: 0.0.1.3 ==did the array in generate power, but still duplicates, program running == not done
 */
namespace COMP123_300845885_A2
{
    class SuperHero : Hero
    {

        /// private instance Var +++++++++++++++++++++++
        private string[] _superPowers;



        public SuperHero(string Name) : base(Name)
        {
           
            this._generateRandomPowers();

        }



        public string[] SuperPowers
        {
            get
            {
                return _superPowers;
            }

            set
            {
                _superPowers = value;
            }
        }

        // Private method++++++++++++++++++++++++
        private void _generateRandomPowers() //generates three random powers
        {
            string[] powers = new string[6] { "SuperSpeed", "Super Strength ", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            Random random = new Random();
            string[] superPowers = new string[3];
            
            for (int i = 0; i <= 2; i++)
            {
                int selectPower = random.Next(5);
                
            }
          

        }







        //Public Method++++++++++++++++++++
        public void ShowPowers() // shows to the console == 
        {
            string[] powers = new string[6] { "SuperSpeed", "Super Strength ", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            Random random = new Random();
            string[] superPowers = new string[3];
            Console.WriteLine("Your super powers are :   ");
            for (int i = 0; i <= 2; i++)
            {
                int selectPower = random.Next(5);
                superPowers[i] = powers[selectPower];
            }
            foreach (string i in superPowers)
            {
                Console.WriteLine(i);
                
            }
          
        }

    }
}
