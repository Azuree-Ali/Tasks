namespace Bonus_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vehicle type (1-Car, 2-Motorcycle, 3-Truck): ");
            int vehicleClassID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter parking hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter membership type (0-None, 1-Silver, 2-Gold): ");
            int membership = Convert.ToInt32(Console.ReadLine());

            int pricePerHour = 0;
            string vehicleType = "";

            switch (vehicleClassID)
            {
                case 1:
                    pricePerHour = 10;
                    vehicleType = "Car";
                    break;
                case 2:
                    pricePerHour = 5;
                    vehicleType = "Motorcycle";
                    break;
                case 3:
                    pricePerHour = 20;
                    vehicleType = "Truck";
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type");
                    break;
            }

            double totalPrice;

            if (hours <= 2)
            {
                totalPrice = hours * pricePerHour;
            }
            else
            {
                int extraHours = hours - 2;
                totalPrice = (2 * pricePerHour) + (extraHours * pricePerHour * 1.5);
            }

            string membershipType = "";
            double discount = 0;

            switch (membership)
            {
                case 0:
                    membershipType = "None";
                    discount = 0;
                    break;
                case 1:
                    membershipType = "Silver";
                    discount = 0.10;
                    break;
                case 2:
                    membershipType = "Gold";
                    discount = 0.20;
                    break;
                default:
                    Console.WriteLine("Invalid membership type");
                    break;
            }

            totalPrice -= totalPrice * discount;

            Console.WriteLine($"Total Parking Hours: {hours}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Membership Type: {membershipType}");
            Console.WriteLine($"Final Price: {totalPrice}");
        }
    }
}
