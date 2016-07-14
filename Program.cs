using System;
using Zoo;

namespace StartOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Starting Program...");
           Animal my_animal = new Animal(); // Creates an instance of the type "Animal"
           Console.WriteLine(my_animal.ToString());

           Console.WriteLine("The Animal is: " + my_animal.sleep());

           Dog my_dog = new Dog(); // Creates an instance of the type "Dog" or Brings a Dog to life
           Console.WriteLine("The Dog is: " + my_dog.sleep());

           Console.WriteLine("Animal dancing? " + my_animal.dance());

           Console.WriteLine("Dog dancing? " + my_dog.dance());

           Cat my_cat = new Cat(); //Creates an instance of the type "Cat" or Brings a Cat to life

           Console.WriteLine("The Cat said: " + my_cat.meow());
           Console.WriteLine("The Cat said: " + my_cat.meow(2));
           Console.WriteLine("The Cat said: " + my_cat.meow(-5));

           Console.WriteLine("Ending Program...");
        }
    }
}
