using System;
using Zoo;

namespace StartOOP
{
    public class Program
    {
        // Main is an Entry Point (An entry point is a door that is used to begin the project)
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

           //my_cat.purr(); // Cannot be called outside of the Cat class due to the "purr" method being private.
           Console.WriteLine("Then the Cat said: " + my_cat.meowThenPurr();
          // my_cat.swim(); //Swing method is protected and cannot be used outside of the Cat, Dog and Animal classes 

           Console.WriteLine("Ending Program...");
        }
    }
}
