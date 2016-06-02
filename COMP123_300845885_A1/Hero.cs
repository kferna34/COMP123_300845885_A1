using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_300845885_A1
{ /*
    *Author: Krytia Fernandez
    *Version: 0.0.0.3 == Program class has 2 heros-- one returns true for the fight method and one tht returns false .. everything works fine so far...
    */
    class Hero
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
                //Console.WriteLine("_name value set");
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


        public Hero(string Name)

        {

            this._name = Name;
            this._generateAbilities(80, 95, 100);

        }
        /*
        *<summary>
        * this is a constuctor that takes strength, speed, health as param
        *assigns the local speedval to the speed prop
        * assigns the local strengthval to the strength prop
        * assigns the local  healthval to the health prop
        *</summary>
        */
        private void _generateAbilities(int strength, int speed, int health)

        {
            this.Strength = strength;
            this.Speed = speed;
            this.Health = health;


        }
        public void Fight(bool hitAttempt)
        {

            // for the condition
            int hit = Strength * 5;
            int health = this.Health - hit;

            if (hitAttempt == true)
            {
                Console.WriteLine("****************You have been hit********************");
                Console.WriteLine(" Damaged by {0},  Remaining Health {1} ", hit * 5, health);
            }

            else
            {
                Console.WriteLine(" The hit did not cause damage, showing overall abilities now");
                Console.WriteLine("=============================================================");
                Console.WriteLine("========================");
                Console.WriteLine("Remaining health {0},Strength:{1},Speed{2} ", Health, this.Strength, this.Speed);
                Console.WriteLine();
            }

        }
        private void _hitAttempt(bool hitAttempt)
        {
            int hit = Strength * 5;
            bool attempt = true;

            if (attempt)
            {
                Console.WriteLine("****************You have been hit********************");
                Console.WriteLine(" Damaged by {0},  Remaining Health {1} ", hit * 5, Health);
            }
            else
            {
                Console.WriteLine(" The hit did not cause damage, showing overall abilities now");
                Console.WriteLine("Remaining health {0},Strength:{1},Speed{2} ", this.Health, this.Strength, this.Speed);

            }
        }
        private void _hitDamage(int hitDamage)
        {
            int hit = Strength * 5;
            Console.WriteLine(" Damaged by {0},  Remaining Health {1} ", hit * 5, Health - hit);

        }
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
