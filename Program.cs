using System;

namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
            {
                get{ return health;}
            }
     
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int strength,int intell, int dex, int heal)
        {
            Name = name;
            Strength = strength;
            Intelligence = intell;
            Dexterity = dex;
            health = heal;
        }
        public int Attack(Human target)
        {
            target.health = target.health-(5*health);
            return target.health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          var bill = new Human("Bill", 5,99,10,100);
          var gates = new Human("Gates", 4,96,10,100);

          gates.Attack(bill);

          Console.WriteLine(bill.Health);
          
        }
    }
}
