namespace Task_6
{
    enum Level
    {
        Easy,
        Medium,
        Hard
    }
    abstract class Question
    {
        public string Header { get; set; }
        public int Marks { get; set; }
        public Level Level { get; set; }

        public abstract void Display();
        public abstract bool CheckAnswer(string answer);
    }
    // true or false question class
    class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public override void Display()
        {
            Console.WriteLine(Header + " (True/False)");
        }
        public override bool CheckAnswer(string answer)
        {
            return answer.ToLower() == CorrectAnswer.ToString().ToLower();
        }
    }
    // choose one question class
    class ChooseOneQuestion : Question
    {
        public string[] Choices { get; set; }
        public int CorrectChoice { get; set; }
        public override void Display()
        {
            Console.WriteLine(Header);
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Choices[i]);
            }
        }
        public override bool CheckAnswer(string answer)
        {
            return Convert.ToInt32(answer) == CorrectChoice;
        }
    }
    // multiple choice question class
    class MultipleChoiceQuestion : Question
    {
        public string[] Choices { get; set; }
        public List<int> CorrectAnswers { get; set; }
        public override void Display()
        {
            Console.WriteLine(Header);
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Choices[i]);
            }
        }
        public override bool CheckAnswer(string answer)
        {
            string[] parts = answer.Split(',');
            List<int> studentAnswers = new List<int>();

            for (int i = 0; i < parts.Length; i++)
            {
                studentAnswers.Add(Convert.ToInt32(parts[i].Trim()));
            }
            // function to compare two lists 
            return studentAnswers.SequenceEqual(CorrectAnswers);
        }
    }
    class ExamSystem
    {
        List<Question> questionBank = new List<Question>();
        public void DoctorMode()
        {
            Console.Write("Enter number of questions: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nChoose Question Type:");
                Console.WriteLine("1. True/False");
                Console.WriteLine("2. Choose One");
                Console.WriteLine("3. Multiple Choice");
                int type = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();
                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Level (0:Easy, 1:Medium, 2:Hard): ");
                Level level = (Level)Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    TrueFalseQuestion q = new TrueFalseQuestion();
                    q.Header = header;
                    q.Marks = marks;
                    q.Level = level;

                    Console.Write("Correct Answer (true/false): ");
                    q.CorrectAnswer = Convert.ToBoolean(Console.ReadLine());
                    questionBank.Add(q);
                }
                else if (type == 2)
                {
                    ChooseOneQuestion q = new ChooseOneQuestion();
                    q.Header = header;
                    q.Marks = marks;
                    q.Level = level;
                    q.Choices = new string[4];

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Choice " + (j + 1) + ": ");
                        q.Choices[j] = Console.ReadLine();
                    }
                    Console.Write("Correct Choice Number (1-4): ");
                    q.CorrectChoice = Convert.ToInt32(Console.ReadLine());

                    questionBank.Add(q);
                }
                else if (type == 3)
                {
                    MultipleChoiceQuestion q = new MultipleChoiceQuestion();
                    q.Header = header;
                    q.Marks = marks;
                    q.Level = level;
                    q.Choices = new string[4];
                    q.CorrectAnswers = new List<int>();
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Choice " + (j + 1) + ": ");
                        q.Choices[j] = Console.ReadLine();
                    }
                    // decorating the input 
                    Console.Write("Correct Answers (comma separated e.g. 1,3): ");
                    string input = Console.ReadLine();
                    string[] parts = input.Split(',');
                    for (int k = 0; k < parts.Length; k++)
                    {
                        q.CorrectAnswers.Add(Convert.ToInt32(parts[k].Trim()));
                    }
                    questionBank.Add(q);
                }
            }
            Console.WriteLine("Questions Added Successfully!");
        }
        public void StudentMode()
        {
            if (questionBank.Count == 0)
            {
                Console.WriteLine("No questions available.");
                return;
            }
            Console.WriteLine("1. Practical Exam");
            Console.WriteLine("2. Final Exam");
            int examType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose Level (0:Easy,1:Medium,2:Hard): ");
            Level level = (Level)Convert.ToInt32(Console.ReadLine());
            List<Question> questions = new List<Question>();
            for (int i = 0; i < questionBank.Count; i++)
            {
                if (questionBank[i].Level == level)
                {
                    questions.Add(questionBank[i]);
                }
            }
            if (questions.Count == 0)
            {
                Console.WriteLine("No questions for this level.");
                return;
            }
            if (examType == 1)
            {
                int half = questions.Count / 2;
                List<Question> halfQuestions = new List<Question>();

                for (int i = 0; i < half; i++)
                {
                    halfQuestions.Add(questions[i]);
                }
                questions = halfQuestions;
            }
            int score = 0;
            int total = 0;
            Console.WriteLine("Exam Started : ");
            for (int i = 0; i < questions.Count; i++)
            {
                Question q = questions[i];
                q.Display();
                Console.Write("Your Answer: ");
                string ans = Console.ReadLine();
                if (q.CheckAnswer(ans))
                {
                    score += q.Marks;
                }
                total += q.Marks;
            }
            Console.WriteLine("Your Result: " + score + " / " + total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ExamSystem system = new ExamSystem();
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1 Doctor Mode");
                Console.WriteLine("2 Student Mode");
                Console.WriteLine("3 Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    system.DoctorMode();
                else if (choice == 2)
                    system.StudentMode();
                else if (choice == 3)
                {
                    Console.WriteLine("hope you best");
                    return;
                }
            }
        }
    }
}
