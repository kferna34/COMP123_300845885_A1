﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_300845885_A1
{ /*
    *Author: Krytia Fernandez
    * ASSIGNMENT 01--COMP1232016
    *Student Number: 300845885
    *Last Modified :June 02,2016
    *Description: A program made of different methods to implement a Hero class
    *Version: 0.0.1.1 ==  Assignment 2:  created the properties, methods, and arrays;== not done
   */
    public  class Hero
    {

        //*******************************PRIVATE INSTANCE VAR*******************************************************
        int _strength;
        int _speed;
        int _health;
        string _name;
        //******************************PUBLIC PROP//***************************************************************



        public string Name
        {
            get
            {
                return this._name;

            }
            set
            {

                this._name = value;
            }
        }

        public bool hitAttempt
        {
            get
            {
                return hitAttempt;
            }
            set
            {
                hitAttempt = value;
            }
        }

        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                _strength = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }
        // where the name is assigned to the hero class

        public Hero(string Name)

        {

            this._name = Name;
            this._generateAbilities(80, 95, 100);

        }
        /*
        *<summary>
        * this is a constuctor that takes strength, speed, health as param ==all are int
        *</summary>
        assigns the local speedval to the speed property
        * assigns the local strengthval to the strength property
        * assigns the local  healthval to the health prop property
        *
        */
        private void _generateAbilities(int strength, int speed, int health)
        {
            this.Strength = strength;
            this.Speed = speed;
            this.Health = health;
        }
        /*
       *<summary>
       * this is a constuctor that refers back to the private property _hitAttempt and _hitDamage-- conditions for bool is here
       *</summary>
       * consitions for bool is here
       *
       */
        public void Fight(bool hitAttempt)
        {

            // condition for the clculation of health after the damage  
            int hit = Strength * 5; // 
            int health = this.Health - hit;

            if (hitAttempt == true)
            {
                Console.WriteLine("****************You have been hit********************");
                Console.WriteLine(" Damaged by {0},  Remaining Health {1} ", hit * 5, health);
            }

            else
            {
                Console.WriteLine("*** The hit did not cause damage, showing overall abilities now***");
                Console.WriteLine("=============================================================");
                Console.WriteLine("========================");
                Console.WriteLine("Remaining health {0},Strength:{1},Speed{2} ", Health, this.Strength, this.Speed);
                Console.WriteLine();
            }

        }
        /**
        * <summary>
        * This method contains what the output will be when the _hitattempt is trueor false
        *
        * </summary>
        * 
        * @private 
        * @method _hitAttempt 
        * @returns {void} 
        */

        private void _hitAttempt(bool hitAttempt)
        {
            int hit = Strength * 5;

            if (hitAttempt)
            {
                Console.WriteLine("****************You have been hit********************");
                Console.WriteLine(" Damaged by {0},  Remaining Health {1} ", hit * 5, Health);
            }
            else
            {
                Console.WriteLine(" ***The hit did not cause damage, showing overall abilities now***");
                Console.WriteLine("Remaining health {0},Strength:{1},Speed{2} ", this.Health, this.Strength, this.Speed);

            }
        }
        /**
          * <summary>
          * This method calculates damage by multiplying the strength value by a number between 1-6 
          *
          * </summary>
          * 
          * @private
          * @method _hitDamage 
          * @return void 
          */
        private void _hitDamage(int hitDamage)
        {
            int hit = Strength * 5;
            Console.WriteLine(" Damaged by {0},  Remaining Health {1} ", hit * 5, Health - hit);

        }
        /*
       *<summary>
       * this is a constuctor that refers to the public property Show()-- displays the information about the Hero
       *</summary>
       * 
       *
       */
        public void Show()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("                      " + this.Name);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("  strength:         " + this.Strength);
            Console.WriteLine("  speed   :         " + this.Speed);
            Console.WriteLine("  health  :         " + this.Health);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

        }
    }
}
