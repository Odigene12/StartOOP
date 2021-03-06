namespace Zoo
{
    public class Animal {
        public  string sleep() { // This is a Method/Behavior
            return "Zzzzzz...";
        }

        virtual public string dance() {
            // virtual allows behaviors or methods to be redefined by children
            return null; // "null" can serve as a do-nothing placeholder for any type
        }

        private string respiration() { // Children can not use this
            return "breath!";
        }

        protected string swim(){ // Similar to a family secret. Children CAN use this.
            return "Swoosh";
        }
    }

    public class Dog : Animal { // How to inherit behavior from Animal (See the ":")
        override public string dance() {
            // This is where the child is changing the behavior of the parent after the parent gave the child permission using the keyword "virtual"
            return "Rag-Top Don't Stop... Rag-Top don't stop...";
        }
    }


    public class Cat : Animal {

        // Ad-hoc Polymorphism same method, different argument types.
        public string meow() {
            return "meow!";
        }

        private string purr() { // Private methods can on be used from within a class.
            return "purr!";
        }

        public string meowThenPurr(){
            return this.meow() + " " + this.purr();
        }

        public string meow(int number_of_pets) { // This method is called "Overloading". We've OVERLOADED the "meow" method
            if (number_of_pets <= 0) {
              return this.meow();
            } else {
            return "meow! You've pet me!";
            }
        }
    }
}