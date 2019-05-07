using System;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool yesno = true;
            while (yesno == true)
            {
                Console.Write("Welcome to the circle tester \nEnter a radius :");


                double radius = double.Parse(Console.ReadLine());
                Circle c = new Circle(radius);

                Console.WriteLine($"Circumfrance is : {c.CaclculatorCircumfrance()}");
                Console.WriteLine($"Area is : {c.CalculatorArea()} ");
                count++;
                Console.Write("Continue? y/n :");
                string response = Console.ReadLine();
                if(response.ToLower() == "n")
                {
                    yesno = false;
                }
            }
            Console.WriteLine($"Goodbye. You created {count} Circle object(s).");
        }
    }
}
