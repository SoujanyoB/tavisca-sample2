

namespace ConsoleApp1
{
    internal class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }

    internal class Dog : Animal { 
        
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }

        public override void Sing()
        {
            Console.WriteLine("Dog song");
        }

    }
}
