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
 * Version: 0.0.1.2 ==fixed the proper formatting == format ok, program running == not done
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
            string[] powers = new string[6] { "SuperSpeed", "Super Strength ", "Body Armour", "Flight", "Fire Generation", "Weatjer Control" };
        }







        //Public Method++++++++++++++++++++
        public void ShowPowers() // shows to the console == 
        {

        }

    }
}
