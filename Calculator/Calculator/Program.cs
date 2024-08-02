using BasicCalc;
using AdvancedCalc;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalc.BasicCalc basicCalc = new BasicCalc.BasicCalc();
            AdvancedCalc.AdvancedCalc advancedCalc = new AdvancedCalc.AdvancedCalc();

            int num1 = 0;
            int num2 = 0;
            string option;
            string calcOption;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tb - Basic Operations: Add | Subtract | Multiply | Divide");
            Console.WriteLine("\ts - Scientific Operations: Square Root | Power");
            calcOption = Console.ReadLine();

            switch (calcOption)
            {
                case "b":
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.Write("Your option? ");
                    option = Console.ReadLine();

                    if (option == null || !(option == "a" || option == "s" || option == "m" || option == "d"))
                    {
                        Console.WriteLine("Invalid option.");
                    }
                    else
                    {
                        Console.WriteLine("Type a number, and then press Enter");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Type another number, and then press Enter");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case "a":
                                Console.WriteLine($"Your result: {num1} + {num2} = {basicCalc.Add(num1, num2)}");
                                break;
                            case "s":
                                Console.WriteLine($"Your result: {num1} - {num2} = {basicCalc.Subtract(num1, num2)}");
                                break;
                            case "m":
                                Console.WriteLine($"Your result: {num1} * {num2} = {basicCalc.Multiply(num1, num2)}");
                                break;
                            case "d":
                                if (num2 != 0)
                                {
                                    Console.WriteLine($"Your result: {num1} / {num2} = {basicCalc.Divide(num1, num2)}");
                                }
                                else
                                {
                                    Console.WriteLine("Cannot divide by zero.");
                                }
                                break;
                        }
                    }
                    break;

                case "s":
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\tr - SquareRoot");
                    Console.WriteLine("\tp - Power");
                    Console.Write("Your option? ");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "r":
                            Console.WriteLine("Type a number, and then press Enter");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Your result: √{num1} = {advancedCalc.SquareRoot(num1)}");
                            break;
                        case "p":
                            Console.WriteLine("Type a number, and then press Enter");
                            num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Type another number, and then press Enter");
                            num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Your result: {num1}^{num2} = {advancedCalc.Power(num1, num2)}");
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid calculation option.");
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
