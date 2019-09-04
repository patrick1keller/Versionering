// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            Console.Write("Hvad er dit navn? ");
            var navn = Console.ReadLine();

            if(navn == "Patrick"){
               Console.WriteLine("Hello World!"); 
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}