namespace Task_Two_MainQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Add Item");
            Console.WriteLine("2 - Delete Item");
            Console.WriteLine("3 - Update Item");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Item");
                    break;

                case 2:
                    Console.WriteLine("Delete Item");
                    break;

                case 3:
                    Console.WriteLine("Update Item");
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
