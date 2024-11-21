namespace Task_3
{
    class Book
    {
        public string title;
        public string auther;
        public string ISBN;
        public bool availability = true;
        public Book(string title, string auther, string iSBN)
        {
            this.title = title;
            this.auther = auther;
            ISBN = iSBN;
        }
    }
    class Library
    {
        public List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public string BorrowBook(string searchedTitle)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(searchedTitle) && books[i].availability)
                {
                    books[i].availability = false;
                    return $"You borrowed The Book Of Title {searchedTitle} successfully...";
                }
                else if (books[i].title.Contains(searchedTitle) && !books[i].availability)
                {

                    return $"The Book Of Title {searchedTitle} is borrowed from another person";
                }
            }
            return $"The Book Of Title {searchedTitle} is not in the library";
        }
        public string ReturnBook(string returnedBook)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(returnedBook) && !books[i].availability)
                {
                    books[i].availability = true;

                    return $"The Book Of Title {books[i].title}\" have been returned successfully";
                }
                else if (books[i].title.Contains(returnedBook) && books[i].availability)
                {
                    return $"The Book Of Title {books[i].title}\" is not borrowed";
                }
            }
            return $"The Book Of Title {returnedBook} is not in the library";
        }

        public string SearchForBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title.Contains(title) && books[i].availability)
                {

                    return $"The Book Of Title {books[i].title}\" is exist";
                }
                else if (books[i].title.Contains(title) && !books[i].availability)
                {

                    return $"The Book Of Title {title} is borrowed from another person";
                }
            }
            return $"The Book Of Title {title} isn't exist in the library";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            string searchBook = "", borrowBook = "", returnBook = "";
            Console.WriteLine("Welcome to the Library");
            Console.WriteLine("====================================");

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            Console.WriteLine("====================================");

            searchBook = library.SearchForBook("The Great Gatsby");
            Console.WriteLine(searchBook);
            Console.WriteLine("---------------------------------------------");

            searchBook = library.SearchForBook("ouf");
            Console.WriteLine(searchBook);
            Console.WriteLine("---------------------------------------------");

            borrowBook = library.BorrowBook("Gatsby");
            Console.WriteLine(borrowBook);
            Console.WriteLine("---------------------------------------------");

            borrowBook = library.SearchForBook("The Great Gatsby");
            Console.WriteLine(borrowBook);
            Console.WriteLine("---------------------------------------------");

            borrowBook = library.BorrowBook("1984");
            Console.WriteLine(borrowBook);
            Console.WriteLine("---------------------------------------------");

            borrowBook = library.BorrowBook("1984");
            Console.WriteLine(borrowBook);
            Console.WriteLine("---------------------------------------------");

            borrowBook = library.BorrowBook("Harry Potter");
            Console.WriteLine(borrowBook);
            Console.WriteLine("---------------------------------------------");
            // This book is not in the library



            // Returning books
            Console.WriteLine("\nReturning books...");
            Console.WriteLine("====================================");

            returnBook = library.ReturnBook("Gatsby");
            Console.WriteLine(returnBook);
            Console.WriteLine("---------------------------------------------");

            returnBook = library.ReturnBook("Gatsby");
            Console.WriteLine(returnBook);
            Console.WriteLine("---------------------------------------------");

            returnBook = library.ReturnBook("Harry Potter"); // This book is not borrowed
            Console.WriteLine(returnBook);
            Console.WriteLine("---------------------------------------------");

        }
    }
}
    

