using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your first name?\n");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nAnd your last name?\n");
            string lastName = Console.ReadLine();

            Console.WriteLine($"\nHow old are you, {firstName} {lastName}?\n");
            int age = Convert.ToInt32(Console.ReadLine());

            bool even;
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

            Console.WriteLine("\nAnd in what month of the year were you born? (e.g. March = 3)\n");
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


            Console.WriteLine("\nWhat is your favorite color? ROYGBIV only, please.\nType \"help\" if you're confused.\n");
            string color = Console.ReadLine();
            color = color.ToLower();

            string modeOfTransportation = "";

            while (color == "help" || color != "red" ^ color != "orange" ^ color != "yellow" ^ color != "green" ^ 
                   color != "blue" ^ color != "indigo" ^ color != "violet")
            {
                Console.WriteLine("\nROYGBIV means red, orange, yellow, green, blue, indigo, or violet.\n" +
                    "So, what is your favorite color?\n");
                color = Console.ReadLine();
                color.ToLower();
                if (color == "red")
                {
                    modeOfTransportation = "camel";
                }
                else if (color == "orange")
                {
                    modeOfTransportation = "horseback";
                }
                else if (color == "yellow")
                {
                    modeOfTransportation = "chariot";
                }
                else if (color == "green")
                {
                    modeOfTransportation = "sailboat";
                }
                else if (color == "blue")
                {
                    modeOfTransportation = "flying carpet";
                }
                else if (color == "indigo")
                {
                    modeOfTransportation = "hot air balloon";
                }
                else if (color == "violet")
                {
                    modeOfTransportation = "foot";
                }
            }


            Console.WriteLine("\nAnd finally, how many siblings do you have?\n");
            int siblingCount = Convert.ToInt32(Console.ReadLine());

            string location;
            if (siblingCount == 0)
            {
                location = "Naples";
            }
            else if (siblingCount == 1)
            {
                location = "Venice";
            }
            else if (siblingCount == 2)
            {
                location = "Rome";
            }
            else if (siblingCount == 3)
            {
                location = "Florence";
            }
            else if (siblingCount >=4)
            {
                location = "Genoa";
            }
            else
            {
                location = "Siberia";
            }

            Console.WriteLine($"\n{firstName} {lastName} will retire in {numberOfYears} with {bankBalance} in the bank,\n" +
                $"a vacation home in {location}, and travel by {modeOfTransportation}.");
            
        }
    }
}
