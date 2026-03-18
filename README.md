// Search Task for Task 5 :
// Q1
        List<int> numbers = new List<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.Int32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int num = Convert.Int32(Console.ReadLine());
            if (numbers.Contains(num)) // Checks if the list contains the num
            {
                throw new Exception("Duplicate number detected!");
            }
            numbers.Add(num);
        }
        Console.WriteLine("All numbers are unique.");
    }
    // Q2
    class Program
{
    static void CheckVowels(string text)
    {
        string vowels = "aeiouAEIOU";
        bool hasVowel = false;
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (text[i] == vowels[j])
                {
                    hasVowel = true;
                    break;
                }
            }
        }
        if (!hasVowel)
        {
            throw new Exception("The string does not contain vowels!");
        }
        Console.WriteLine("The string contains vowels.");
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        CheckVowels(input);
    }
}
