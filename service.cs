namespace FinalProject
{
    internal class Service : IRentable
    {
        public List<Book> books = new List<Book>();
        public List<RentedBook> rented = new List<RentedBook>();

        // Catalog initialization with default books
        public Service()
        {           
            books.Add(new Book("The Great Gatsby", "B001", "F. Scott Fitzgerald"));
            books.Add(new Book("To Kill a Mockingbird", "B002", "Harper Lee"));
            books.Add(new Book("1849", "B003", "George Orwell"));
            books.Add(new Book("Dune", "B004", "Frank Herbert"));
        }        

        public void AddBook()
        {
            Console.WriteLine("=============== Add a New Book ===============");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter book title: ");
            string bookNameEntered = Console.ReadLine();

            Console.Write("Enter the books Unique ID: ");
            string bookIdEntered = Console.ReadLine();

            Console.Write("Enter authors name: ");
            string bookAuthorEntered = Console.ReadLine();

            // Instantiate and catalog the new book
            Book newBook = new Book(bookNameEntered, bookIdEntered, bookAuthorEntered);
            books.Add(newBook); 
            
            Console.WriteLine();
            Console.WriteLine($"Success: '{bookNameEntered}' has been added to the library catalog.");
        }

        public void RemoveBook()
        {
            Console.WriteLine("=============== Remove a Book ===============");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Enter the exact title of the book to remove: ");
            string name = Console.ReadLine();

            Book bookToRemove = books.Find(b => b.BookName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Success: '{name}' has been removed from the system.");
            }
            else
            {
                Console.WriteLine("Error: Book not found in our system.");
            }

            Console.WriteLine();
            Console.WriteLine("--- Updated Library Inventory ---");
            foreach (Book bookA in books)
            {
                bookA.DisplayBookDetails();
            }
        }

        public void ViewBook()
        {
            Console.WriteLine("=============== Library Collection ===============");
            Console.WriteLine("--------------------------------------------------");

            if (books.Count == 0)
            {
                Console.WriteLine("The library inventory is currently empty.");
                return;
            }

            foreach (Book book in books)
            {
                book.DisplayBookDetails();
            }
        }

        public void LookUpBook()
        {
            Console.WriteLine("=============== Search Catalog ===============");
            Console.WriteLine("----------------------------------------------");

            Console.Write("Enter book title to search: ");
            string searchTitle = Console.ReadLine();

            Book foundBook = books.Find(b => b.BookName.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null) 
            {
                Console.WriteLine($"Match Found! '{foundBook.BookName}' is available.");
            }
            else 
            {
                Console.WriteLine("Sorry, we couldn't find a book with that title.");
            }
        }

        public void RentBook(User user, string title)
        {
            Console.WriteLine("=============== Book Rental ===============");
            Console.WriteLine("-------------------------------------------");

            Book foundBook = null;
            
            foreach (Book b in books)
            {
                if (b.BookName.ToLower() == title.ToLower())
                {
                    foundBook = b;
                    break;
                }
            }

            if (foundBook == null)
            {
                Console.WriteLine("Rental Error: Requested book is not in our inventory.");
                return;
            }

            // Verify availability status
            foreach (RentedBook rentedBook in rented)
            {
                if (rentedBook.Book.BookName.ToLower() == foundBook.BookName.ToLower())
                {
                    Console.WriteLine("Status: This book is currently checked out by another reader.");
                    return;
                }
            }

            // Process checkout
            RentedBook newRentedBook = new RentedBook(foundBook, user);
            rented.Add(newRentedBook);

            Console.WriteLine($"Checkout Complete! '{foundBook.BookName}' is now reserved for {user.Username}.");
        }

        public void ListDueDates(User user)
        {
            Console.WriteLine("=============== Your Active Return Dates ===============");
            Console.WriteLine("--------------------------------------------------------");

            bool hasRentals = false;
            foreach (var rent in rented)
            {
                if (rent.Renter.Username == user.Username)
                {
                    Console.WriteLine($"Title: {rent.Book.BookName} | Return Due Date: {rent.DueDate.ToShortDateString()}");
                    hasRentals = true;
                }
            }

            if (!hasRentals)
            {
                Console.WriteLine("You do not have any books currently checked out.");
            }
        }

        public void DisplayRentingFees()
        {
            Console.WriteLine("=============== Rates & Fees ===============");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Standard book rentals are currently free of charge.");
        }

        public void DisplayRentedBooks()
        {
            Console.WriteLine("=============== Active System Rentals ===============");
            Console.WriteLine("-----------------------------------------------------");

            if (rented.Count == 0)
            {
                Console.WriteLine("No books are currently checked out.");
                return;
            }

            foreach (var b in rented)
            {
                Console.WriteLine($"'{b.Book.BookName}' is checked out by user: {b.Renter.Username} (Due: {b.DueDate.ToShortDateString()})");
            }
        }
    }
}
