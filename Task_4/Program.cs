using static System.Reflection.Metadata.BlobBuilder;

namespace Task_4
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;
        bool Isavialable;
        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Isavialable = true;  // by default the book is available when created
        }
        // for encapsulation to access the private data of the class => bonus
        public string GetTitle() // => bouns
        {
            return Title;
        }
        public string GetAuthor() // => bouns
        {
            return Author;
        }
        public string GetISBN() // => bouns
        {
            return ISBN;
        }
        public void Display()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
            Console.WriteLine("ISBN : " + ISBN);
            Console.WriteLine("Available: " + Isavialable);
            Console.WriteLine("==========================");
        }
    }
    class Library
    {
        List<Book> Books = new List<Book>();
        public bool AddBook(string title, string author, string isbn)
        {
            if (title == "" || author == "" || isbn == "") // if any of the data is empty => bonus
            {
                Console.WriteLine("Data musnt be empty");
                return false;
            }
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].GetISBN() == isbn) // if the book is already exists => bonus
                {
                    Console.WriteLine("ISBN already exists.");
                    return false;
                }
            }
            Book newBook = new Book(title, author, isbn);
            Books.Add(newBook);
            Console.WriteLine("Book added successfully.");
            return true;
        }
        public bool RemoveBook(string isbn)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].GetISBN() == isbn) // if the book exists first
                {
                    Books.Remove(Books[i]);
                    Console.WriteLine("Book is removed successfuly");
                    return true;
                }
            }
            Console.WriteLine($"The book with {isbn} is not found to remove");
            return false;
        }
        public bool SearchBook(string name)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].GetTitle() == name || Books[i].GetAuthor() == name)
                {
                    Console.WriteLine("The book is found ");
                    return true;
                }
            }
            Console.WriteLine("The book is not found ");
            return false;
        }
        public void DisplayAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }
            for (int i = 0; i < Books.Count; i++)
            {
                Books[i].Display();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int choice;
            while (true)
            {
                Console.WriteLine("1- Add Book");
                Console.WriteLine("2- Remove Book");
                Console.WriteLine("3- Search Book");
                Console.WriteLine("4- Display all books");
                Console.WriteLine("5- Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title : ");
                        string title = Console.ReadLine();
                        Console.Write("Enter book author : ");
                        string author = Console.ReadLine();
                        Console.Write("Enter book ISBN : ");
                        string isbn = Console.ReadLine();
                        library.AddBook(title , author , isbn);
                        break;
                    case 2:
                        Console.WriteLine("Enter the book ISBN to remove : ");
                        isbn = Console.ReadLine();
                        library.RemoveBook(isbn);
                        break;
                    case 3:
                        Console.Write("Enter book Author or Title to search : ");
                        string s = Console.ReadLine();
                        library.SearchBook(s);
                        break;
                    case 4:
                        library.DisplayAllBooks();
                        break;
                    case 5:
                        Console.WriteLine("Thanks");
                        return;
                    default:
                        Console.WriteLine("Invalid choice try again.");
                        break;
                }
            }
        }
    }
}
