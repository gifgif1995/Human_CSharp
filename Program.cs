using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{

    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        // add a public "getter" property to access health
        public int HealthProp
        {
            get
            {
                return Health;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            this.Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int str, int intel, int dex, int Heal)
        {
            this.Name = name;
            this.Strength = str;
            this.Intelligence = intel;
            this.Dexterity = dex;
            this.Health = Heal;
        }
        // Attack method
        public int Attack(object target)
        {
            Human temp = target as Human;
            temp.Health -= 5 * Strength;
            Console.WriteLine($"Name: {this.Name}, Health level: {temp.HealthProp} percent, keep on fighting!");
            return temp.Health;

        }
    }
    // class program
    class Program
    {
        static void Main(string[] args)
        {
            var NewHuman = new Human("Bill", 25, 40, 10, 100);
            Console.WriteLine($"This person's name is {NewHuman.Name}");
            Console.WriteLine(NewHuman.Strength);
            Console.WriteLine(NewHuman.Intelligence);
            Console.WriteLine(NewHuman.Dexterity);
            Console.WriteLine(NewHuman.HealthProp);
            NewHuman.Attack(NewHuman);
            var NewHuman2 = new Human("Ted", 55, 35, 10, 100);
            Console.WriteLine($"This person's name is {NewHuman2.Name}");
            Console.WriteLine(NewHuman2.Strength);
            Console.WriteLine(NewHuman2.Intelligence);
            Console.WriteLine(NewHuman2.Dexterity);
            Console.WriteLine(NewHuman2.HealthProp);
            NewHuman.Attack(NewHuman2);
        }
    }
}