namespace Task_Two_MainQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days : ");
            int days = Convert.ToInt32(Console.ReadLine());
            if (days < 0)
            {
                Console.WriteLine("Invalid input. Days cannot be negative.");
            }
            else if (days < 10)
            {
                Console.WriteLine("Not Eligible");
            }
            else if (days <= 19)
            {
                Console.WriteLine("Eligible");
            }
            else if (days >= 20)
            {
                Console.WriteLine("Excellent Attendance");
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }
    }
}
