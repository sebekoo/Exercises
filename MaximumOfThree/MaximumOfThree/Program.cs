namespace MaximumOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, który znajdzie maksymalną liczbę spośród trzech podanych liczb

            var exit = true;

            while (exit)
            {
                Menu();
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        For();
                        break;
                    case "2":
                        While_foreach();
                        break;
                    case "3":
                        While_if();
                        break;
                    case "4":
                        DoWhile_if();
                        break;
                    case "5":
                        OptionNotActive();
                        break;
                    default:
                        Console.WriteLine("*** Are you sure want to close program y/n ? ***");
                        var confirmExit = Console.ReadLine();
                        if (confirmExit!.Equals("y"))
                        {
                            exit = false;
                        }
                        Console.Clear();
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("Debugging the program to learn about the different uses of loops and conditions");
            Console.WriteLine("Each of the selected options will produce the same result\n");
            Console.WriteLine("1. Loop \"for\"");
            Console.WriteLine("2. Loop \"while_foreach\"");
            Console.WriteLine("3. Loop \"while_if\"");
            Console.WriteLine("4. Loop \"do while_if\"");
            Console.WriteLine("4. Option not active");
            Console.WriteLine("Press other any key to exit");
        }

        static void For()
        {
            Console.Clear();
            List<float> list = [];
            for (float i = 1; i < 4; i++)
            {
                Console.Write($"Type number {i}: ");
                bool v = float.TryParse(Console.ReadLine(), out float result);
                list.Add(result);
                i = list.Count;
            }
            Console.WriteLine($"The figures given are {list[0]}, {list[1]}, {list[2]}, ");
            Console.WriteLine($"Of the given numbers, the maximum is: {list.Max()}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        static void While_foreach()
        {
            List<float> list = [];

            while (list.Count < 3)
            {
                Console.Write("Enter number: ");
                var input = Console.ReadLine();
                if (float.TryParse(input, out float result))
                {
                    list.Add(result);
                }
                else
                {
                    Console.WriteLine("The stated value is not a number");
                }
            }
            string listOfNumbers = "This is your list of numbers: ( ";

            foreach (var number in list)
            {
                listOfNumbers += $"{number}";
            }
            var MaxValue = list.Max();
            Console.WriteLine($"{listOfNumbers}");
            Console.WriteLine($"Your max is {MaxValue}, ");
        }

        static void While_if()
        {
            Console.Clear();
            List<float> list = [];
            while (list.Count < 3)
            {
                Console.Write($"Enter number: ");
                var number = Console.ReadLine();
                if (float.TryParse(number, out float result))
                {
                    list.Add(result);
                }
                else
                {
                    Console.WriteLine("The stated value is not a number");
                }
            }
            Console.WriteLine($"The figures given are {list[0]}, {list[1]}, {list[2]} ");
            Console.WriteLine($"Of the given numbers, the maximum is: {list.Max()}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        static void DoWhile_if()
        {
            float first, second, third;
            bool answer;
            do
            {
                Console.Clear();
                Console.Write("Type first number: ");
                var a = Console.ReadLine();
                if (float.TryParse(a, out first))
                {
                    Console.WriteLine($"Entered {first}");
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid input integer");
                    answer = AskToContinue();
                }
            } while (answer);

            Console.Clear();
            Console.Write("Type second number: ");
            var b = Console.ReadLine();

            do
            {
                if (float.TryParse(b, out second))
                {
                    Console.WriteLine($"Entered {second}");
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid input integer");
                    answer = AskToContinue();
                }
            } while (answer);

            Console.Clear();
            Console.Write("Type third number: ");
            var c = Console.ReadLine();

            do
            {
                if (float.TryParse(c, out third))
                {
                    Console.WriteLine($"Entered {third}");
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid input integer");
                    answer = AskToContinue();
                }
            } while (answer);

            Console.WriteLine($"Your numbers {first}, {second}, {third}");
            if (first > second && first > third)
            {
                Console.WriteLine($"Max number is: {first}");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine($"Max number is: {second}");
            }
            else
            {
                Console.WriteLine($"Max number is: {third}");
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void OptionNotActive()
        {
            Console.WriteLine("Option not active"); ;
        }

        static bool AskToContinue()
        {
            Console.Write("Do you want to continue? y / n: ");
            string response = Console.ReadLine()!.Trim();
            return response.Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}

