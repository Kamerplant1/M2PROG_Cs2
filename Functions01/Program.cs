using System;

namespace Functions01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        //Program is de variable
        //Type is int
        //Program is type 
        //return type is void
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("About 3 days");
        }
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1(); 
        }
    }
}
