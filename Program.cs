using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human a = new Human("John");
            Human b = new Human("Connor");
            a.Attack(b);
            Console.WriteLine(b.Health);
            
        }
    }
}
