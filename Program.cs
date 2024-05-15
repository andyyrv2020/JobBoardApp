using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Controller controller = new Controller();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputArgs = input.Split(' ');
            string command = inputArgs[0];
            List<string> commandArgs = new List<string>(inputArgs[1..]);

            string result = command switch
            {
                "AddCategory" => controller.AddCategory(commandArgs),
                "AddJobOffer" => controller.AddJobOffer(commandArgs),
                "GetAverageSalary" => controller.GetAverageSalary(commandArgs),
                "GetOffersAboveSalary" => controller.GetOffersAboveSalary(commandArgs),
                "GetOffersWithoutSalary" => controller.GetOffersWithoutSalary(commandArgs),
                _ => "Invalid command!"
            };

            Console.WriteLine(result);
        }
    }
}
