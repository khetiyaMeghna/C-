using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
    abstract class animal //abstract claa
    {
        public abstract void makeSound();//abstract method (with no body)

        public void Sleep()  // Normal method (with body)
        {
            Console.WriteLine("This animal is sleeping.");
        }

    }
    class Dog : animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
    internal class abstract_class
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.makeSound();//call overridden method
            d.Sleep();
            Console.ReadLine();
        }
        
    }
}
