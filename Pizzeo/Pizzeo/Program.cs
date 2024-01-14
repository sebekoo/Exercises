using System.Collections.Concurrent;

namespace Pizzeo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("PIZZA\n");
            int diameterPizza1;
            int diameterPizza2;

            decimal pricePizza1;
            decimal pricePizza2;

            double fieldPizza1;
            double fieldPizza2;

            double fieldPizza1ForGold;
            double fieldPizza2ForGold;

            Console.Write("Type the diameter of the pizza 1: ");
            diameterPizza1 = int.Parse(Console.ReadLine());
            Console.Write("Type of price pizza 1    : ");
            pricePizza1 = decimal.Parse(Console.ReadLine());

            Console.Write("Type the diameter of the pizza 2: ");
            diameterPizza2 = int.Parse(Console.ReadLine());
            Console.Write("Type of price pizza 2    : ");
            pricePizza2 = decimal.Parse(Console.ReadLine());

            fieldPizza1 = PizzaField(diameterPizza1);
            fieldPizza2 = PizzaField(diameterPizza2);

            fieldPizza1ForGold = FieldPizzaForGold(fieldPizza1, pricePizza1);
            fieldPizza2ForGold = FieldPizzaForGold(fieldPizza2, pricePizza2);

            Console.WriteLine($"\nFor 1 $ you will recive : {fieldPizza1ForGold} cm^2 pizza 1.");
            Console.WriteLine($"                     or : {fieldPizza2ForGold} cm^2 pizza 2.\n");

            if (fieldPizza1ForGold > fieldPizza2ForGold)
            {
                Console.WriteLine("Pizza 1 is more cost-effective.");
            }
            else if (fieldPizza1ForGold < fieldPizza2ForGold)
            {
                Console.WriteLine("Pizza 2 is more cost-effective.");
            }
            else
            {
                Console.WriteLine("Both pizzas are equally viable.");
            }
        }

        private static double FieldCircle(double radius)
        {
            return 3.14 * radius * radius;
        }

        private static double PizzaField(int diameter)
        {
            return FieldCircle(diameter / 2d);
        }

        private static double FieldPizzaForGold(double fieldPizza, decimal pricePizza)
        {
            return (fieldPizza / (double)pricePizza);
        }
    }
}