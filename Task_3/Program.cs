namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();         
            Console.WriteLine("Menu options : ");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("Q - Quit");
            while (true)
            {
                Console.WriteLine("Enter your choice : ");
                char Choice = Convert.ToChar(Console.ReadLine());
                switch (Choice)
                {
                    case 'P':
                    case 'p':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            // displaying the numbers in the list 
                            Console.WriteLine(string.Join(" , ", numbers));
                        }
                        break;                  
                    case 'A':
                    case 'a': 
                        Console.WriteLine("Enter the number to be added : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        // A flag to search for an element in the list equals to the input value
                        bool IsDuplicate = false;
                        for(int i = 0; i< numbers.Count; i++)
                        {
                            if (num == numbers[i])
                            {
                                IsDuplicate = true;
                            }
                        }
                        if (!IsDuplicate)
                        {
                            numbers.Add(num);
                            Console.WriteLine($"{num} added");
                        }
                        else
                        {
                            Console.WriteLine("Duplicate entries can't be added again!!!!!");
                            Console.WriteLine("Try another number : ");
                        }
                        break;
                    case 'M':
                        case 'm':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            double mean = numbers.Average();
                            Console.WriteLine($"The mean is : {mean}");
                        }
                        break;

                    case 'S':
                        case 's':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                
                                if(smallest > numbers[i])
                                {
                                    smallest = numbers[i];
                                }
                               
                            }
                            Console.WriteLine($"The smallest number is : {smallest}");
                        }
                        break;

                    case 'L':
                        case 'l':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {

                                if (largest < numbers[i])
                                {
                                    largest = numbers[i];
                                }

                            }
                            Console.WriteLine($"The largest number is : {largest}");
                        }
                        break;

                    case 'Q':
                        case 'q':
                        Console.WriteLine("Goodbye!");
                        // Clearing the list after quiting
                        numbers.Clear();
                        return;
                    default :
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }

            }
        }
    }
}
