namespace Task_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's carpet cleaning service");
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of Small carpets : ");
            int num_Small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Large carpets : ");
            int num_large = Convert.ToInt32(Console.ReadLine());
            double tax = 0.06 * ((num_Small * 25) + (num_large * 35));
            Console.WriteLine("Price per small carpet : $25");
            Console.WriteLine("Price per large carpet : $35");
            Console.WriteLine($"Cost : ${(num_Small * 25) + (num_large * 35)}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine($"===================================");
            Console.WriteLine($"Total estimate : ${(num_Small * 25) + (num_large * 35) + tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
        }
    }

