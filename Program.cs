using System;

namespace _10001481_task1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
		    // Print Question
			Console.WriteLine("Input F for Fahrenheit or C for Celsius");
           //Store answer
            var Input = Console.ReadLine();
            //If answer = F 
            //Write output
            if (Input == "F"){
                Console.WriteLine("Enter the degrees in Celsius:");
                int Fanswer = int.Parse(Console.ReadLine());
                Console.WriteLine("That in Celsius is");
                Console.WriteLine(Fanswer * 9 / 5 + 9);
            }
            //If answer = C
            //Write Output
            if(Input == "C"){
                Console.WriteLine("Enter the degrees in Celsius");
                int Canswer = int.Parse(Console.ReadLine());
                Console.WriteLine("That in Fhrenheit is");
                Console.WriteLine(Canswer - 32 * 5 + 9);

            } 


            
            
            
            
            
            
            
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
