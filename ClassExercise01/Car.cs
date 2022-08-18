using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise01
{
    internal class Car
    {
        public Car()
        {

        }
        
        public string? Make { get; set; }

        public string? Model { get; set; }
        
        public int Year { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine($"The Make of Your Car is: {Make}");
            Console.WriteLine($"The Model of Your Car is: {Model}");
            Console.WriteLine($"The Year of Your Car is: {Year}");
        }

       

    }
    public class GettingInput
    {
        public static int GetYear()
        {
            bool numCheck;
            Console.WriteLine("Please enter your Year: ");
            numCheck = int.TryParse(Console.ReadLine(), out int num);

            while (!numCheck)
            {
                Console.WriteLine("Please enter your Year: ");
                numCheck = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }

        public static string? GetStringInput(int Reference)
        {

            string? userInput;
            bool nullCheck;

            if (Reference == 1)
            {
                Console.WriteLine("Please enter the Make of your vehicle: ");
                userInput = Console.ReadLine();
                nullCheck = string.IsNullOrEmpty(userInput);

                while (nullCheck)
                {
                    Console.WriteLine("Please enter the Make of your vehicle: ");
                    userInput = Console.ReadLine();
                    nullCheck = string.IsNullOrEmpty(userInput);
                }
            }
            else
            {
          
                Console.WriteLine("Please enter the model of your vehicle: ");

                userInput = Console.ReadLine();
                nullCheck = string.IsNullOrEmpty(userInput);

                while (nullCheck)
                {
                    Console.WriteLine("Please enter the model of your vehicle: ");
                    userInput = Console.ReadLine();
                    nullCheck = string.IsNullOrEmpty(userInput);
                }
            }
            return userInput;
        }
    }
}
