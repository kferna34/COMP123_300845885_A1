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
 * Version: 0.0.1.4 ==did the array in generate power, program runninG.. cant figure out how to use list instead of array
 */
namespace COMP123_300845885_A2
{
    class SuperHero : Hero
    {

        /// private instance Var +++++++++++++++++++++++
        private string[] _superPowers;



        public SuperHero(string Name) : base(Name)
        {

        }

        string superPowers;
        private string Power;

        public string Powers
        {
            get { return superPowers; }
            set { superPowers = value; }
        }

        public string PowerList { get; private set; }

        // Private method++++++++++++++++++++++++
        private void _generateRandomPowers(string powers) //generates three random powers

        {

        }
        public void ShowPowers()
        {//list of the six powers
            string[] powers = new string[6] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };

            //Using the Random class to give a number
            Random random = new Random();

            //This string array is storing the super powers generated
            string[] superPowers = new string[3];
            Console.WriteLine("Your super powers are:");

            //Loops three times (0-2) if you put 3 you'll get that IndexOutOfBounds (something like that) exception thing
            for (int i = 0; i <= 2; i++)
            {
             
                int selectPower = random.Next(5);
                superPowers[i] = powers[selectPower];
            };

            //This is just printing out the values
            foreach (string i in superPowers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
