namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [];
            List<int> primeList = [2];
            string inputUser;
            int number;
            do
            {
                Console.Write("Enter integer number > 1: ");
                inputUser = Console.ReadLine();
                var integer = int.TryParse(inputUser, out number);

            } while (number < 2);

            for (int i = 2; i <= number; i++)
            {
                list.Add(i);
            }
            
            //Console.WriteLine("*** List ***");
            //foreach (int element in list)
            //{
            //    Console.Write($"{element}, ");
            //}

            for (int j = 0; j < primeList.Count; j++)
            {
                for (int k = 0; k < list.Count; k++)
                {
                    if (list[k] % primeList[j] == 0)
                    {
                        list.RemoveAt(k);
                    }
                }
                if (list.Count > 0)
                {
                    primeList.Add(list[0]);
                    list.RemoveAt(0);
                }
            }

            Console.WriteLine("\n*** Prime List ***");
            foreach (int element in primeList)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
