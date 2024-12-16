using System;
using System.Threading.Tasks;

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
        }
        internal void Vraag2() {
            Console.WriteLine("about 5 weeks");
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord2 = Console.ReadLine();
        }
        internal void Vraag3() {
            Console.WriteLine("buy stuff");
            string antwoord3 = Console.ReadLine();
        }
        internal void Vraag4() {
            Console.WriteLine("What would you buy first?");
            string antwoord4 = Console.ReadLine();
            Console.WriteLine("A red chevrolet");
        }
        internal void Vraag5()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord5 = Console.ReadLine();
            Console.WriteLine("Idk maybe mosquitos");
        }
            
          
        
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1(); 
        }
    }
}
