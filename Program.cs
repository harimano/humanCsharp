using System;
using System.Collections.Generic;
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

    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 


        public Food(string name, int cals, bool spice, bool sweet)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spice;
            IsSweet = sweet;
        }

    }

    class Buffet
    {
        public List<Food> Menu;
        
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
               new Food("Example1", 1000, false, false),
               new Food("Example2", 1000, false, false),
               new Food("Example3", 1000, false, false),
               new Food("Example4", 1000, false, false),
               new Food("Example5", 1000, false, false),
               new Food("Example6", 1000, false, false),
               new Food("Example7", 1000, false, false),
            };
        }
     
        public Food Serve()
        {
            Random rand = new Random();
            int foodchoice = rand.Next(0,Menu.Count);
        
            return Menu[foodchoice];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>(); 
        }
     public bool IsFull
    {
        get
        {
            if(calorieIntake>1200)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }     
        public void Eat(Food item)
        {
            if(IsFull==false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine(calorieIntake);
            }
            else
            {
                Console.WriteLine("Ninja is FULL");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        //   var bill = new Human("Bill", 5,99,10,100);
        //   var gates = new Human("Gates", 4,96,10,100);

        //   gates.Attack(bill);

        //   Console.WriteLine(bill.Health);
          var buffet = new Buffet();
          var ninja = new Ninja();
          var food = buffet.Serve();
          ninja.Eat(food);
          ninja.Eat(food);
          ninja.Eat(food);

        }
    }
}
