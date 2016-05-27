using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_300845885_A1
{ /*
    *Author: Krytia Fernandez
    *Version: 0.0.0. == did the _generate() to display speed, strength&health&& set the properties, also as the condition for the hitattempt ==not done 
    */
    class Hero
    {
        //+++++++++++++++++++++Private var++++++++++++++++++
        private int _strength { get; set; }
        private int _speed { get; set; }
        private int _health { get; set; }
        private string _name;
        public bool _hitAttempt { get; private set; }
        public int _hitDamage { get; private set; }
        //+++++++++++++++++++++Public Var++++++++++++++++++
        public string Name
        {
            get

            {

                return this.Name;

            }

            set

            {

                this.Name = value;
            }
        }



        public Hero(string name)
        {
            this.Name = name;
            this._generateAbilities();//call method  == nts:() means method

        }

        private void _generateAbilities() //returns strength, speed,health
        {
            Console.WriteLine(_strength);
            Console.WriteLine(_speed);
            Console.WriteLine(_health);
        }

        public void Fight()
        {
            if (_hitAttempt == true)
            {
               
                Console.WriteLine(_hitAttempt);
                
            }
        }
    }

    public void Show()
    {

    }
    private bool _hitAttempt()
    {
       
    }

    private int _hitDamage()
    {

    }


    //+++++++Private Method+++++++++
    //+++++++Public Medod+++++++++
}
}