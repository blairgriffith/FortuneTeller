using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your first name?\n");
            string firstName = Console.ReadLine();

            Console.WriteLine("And your last name?\n");
            string lastName = Console.ReadLine();

            Console.WriteLine($"How old are you, {firstName} {lastName}?\n");
            int age = Convert.ToInt32(Console.ReadLine());

            bool even;
            //Handles even/odd distinction
            if (age % 2 == 0)
            {
                even = true;
            }else{
                even = false;
            }
            string numberOfYears;
            if (even == true)
            {
                numberOfYears = "22 years";
            }else{
                numberOfYears = "50 years";
            }

            Console.WriteLine("And in what month of the year were you born? (e.g. March = 3)");
            int month = Convert.ToInt32(Console.ReadLine());

            string bankBalance;
            if(month >=1 && month <= 4)
            {
                bankBalance = "$8,675,309";
            }else if(month >=5 && month <= 8)
            {
                bankBalance = "$90,210";
            }else if(month >=9 && month <= 12)
            {
                bankBalance = "$18,005,552,456";
            }else{
                bankBalance = "-$1,000,000,000";
            }


            Console.WriteLine("What is your favorite color? ROYGBIV only, please. type \"help\" if you're confused.");
            string color = (Console.ReadLine());

            Console.WriteLine("And finally, how many siblings do you have?");
            int siblingCount = Convert.ToInt32(Console.ReadLine());

            string location;
            if(siblingCount == 0)
            {
                
            }


            Console.WriteLine($"{firstName} {lastName} will retire in {numberOfYears} with {bankBalance} in the bank,\n" +
                $"a vacation home in {{location}}, and travel by {{modeOfTransportation}}");
            
        }
    }
}
