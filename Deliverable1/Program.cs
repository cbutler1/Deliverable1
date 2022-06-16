using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            
            //calculate ceiling
           
            do
            {
                Console.WriteLine("How many people are we making PB & J sandwiches for? ");
                decimal sandwich = int.Parse(Console.ReadLine());
                decimal slice = sandwich * 2;
                decimal tablespoon = sandwich * 2;
                decimal teaspoon = sandwich * 4;
                decimal loave1 = slice / 28;
                decimal jar1 = tablespoon / 32;
                decimal jam1 = teaspoon / 48;
                decimal loave = Math.Ceiling(loave1);
                decimal jar = Math.Ceiling(jar1);
                decimal jam = Math.Ceiling(jam1);
                if (sandwich > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You need:");
                    Console.WriteLine();
                    Console.WriteLine("{0} slices of bread", slice);
                    Console.WriteLine("{0} tablespoons of peanut butter", tablespoon);
                    Console.WriteLine("{0} teaspoons of jelly", teaspoon);
                    Console.WriteLine();
                    Console.WriteLine("Which is...");
                    Console.WriteLine();
                    Console.WriteLine("{0} loaves of bread", loave);
                    Console.WriteLine("{0} jars of peanut butter", jar);
                    Console.WriteLine("{0} jars of jelly", jam);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                input = Console.ReadLine();
            } while (input.Equals("yes") || input.Equals("y"));
            
            

                


            






             
                

                
                {
                    Console.WriteLine("Goodbye!");
                }







            

        }
    }

}
    

