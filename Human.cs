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

        // add a public "getter" property to access health
        public int Health
        {
            get {return health;}
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human( string n )
        {
            Name = n;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;

        }

        // Add a constructor to assign custom values to all fields
        public Human(string n, int str, int itl, int dex, int hth)
        {
            Name = n;
            Strength = str;
            Intelligence = itl;
            Dexterity = dex;
            health = hth;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= 5 * Strength;
            return target.Health;
        }
    }
}