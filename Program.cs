using System.Net;

namespace LibraryManagementApp._2
{
    internal class Program
    {
        static List<Book> books = new List<Book>();
        static List<Member> members = new List<Member>();
        static List<Transaction> transactions = new List<Transaction>();
        static void Main(string[] args)
        {
            int loginOption;

            do
            {
                Console.WriteLine("========== LIBRARY MANAGEMENT SYSTEM ==========");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. Member Login");
                Console.WriteLine("99. Exit");
                Console.WriteLine("===============================================");
                Console.Write("Enter your choice: ");

                loginOption = Convert.ToInt32(Console.ReadLine());

                switch (loginOption)
                {
                    case 1:
                        AdminLogin();
                        break;

                    case 2:
                        MemberLogin();
                        break;

                    case 99:
                        Console.WriteLine("Thank you for using the Library Management Application!!!");
                        break;

                    default:
                        Console.WriteLine("Invalid option!!! Please try again.");
                        break;
                }

            } while (loginOption != 99);

        }//End of Main    
        public static void AdminLogin()
        {
            string correctUsername = "admin";
            string correctPassword = "1234";

            Console.Write("Enter Admin Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Admin Password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Admin login successful.");
                AdminMenu();
            }
            else
            {
                Console.WriteLine("Invalid admin username or password!!!");
            }
        }//End of Admin Login
        public static void MemberLogin()
        {
            string correctUsername = "member";
            string correctPassword = "5678";

            Console.Write("Enter Member Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Member Password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Member login successful.");
                MemberMenu();
            }
            else
            {
                Console.WriteLine("Invalid member username or password.");
            }
        }//End of Member Login 
        public static void MemberMenu()
        {
            int option;
            char choice = 'y';

            do
            {
                Console.WriteLine();
                Console.WriteLine("========== MEMBER MENU ==========");
                Console.WriteLine("=================================");

                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("99. Logout");
                Console.WriteLine("=================================");
                Console.WriteLine("Enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: ViewBooks();
                        break;
                    case 2: SearchBook();
                        break;
                    case 3: BorrowBook();
                        break;
                    case 4: ReturnBook();
                        break;
                    case 99:
                        Console.WriteLine("Logging out...");
                        return;                        
                    default:
                        Console.WriteLine("Wrong selection. Please enter the correct number again!!!");
                        break;
                }

                Console.WriteLine("Do you wish to continue? (y/n)");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y');
        }//End of Member Menu

        public static void AdminMenu()
        {

            int option;
            char choice = 'y';

            do
            {
                Console.WriteLine();
                Console.WriteLine("========== ADMIN MENU ==========");
                Console.WriteLine("=================================");

                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Search Book");               
                Console.WriteLine("3. Add New Book");
                Console.WriteLine("4. Remove Book");
                Console.WriteLine("5. Edit Existing Book Details");
                Console.WriteLine("6. View All Members");
                Console.WriteLine("7. Search Member");
                Console.WriteLine("8. Add New Member");
                Console.WriteLine("9. Remove Member");
                Console.WriteLine("10. Edit Existing Member Details");
                Console.WriteLine("99. Logout");
                Console.WriteLine("=================================");
                Console.WriteLine("Enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: ViewBooks();
                        break;
                    case 2: SearchBook();
                        break;
                    case 3: AddBook();
                        break;
                    case 4: RemoveBook();
                        break;
                    case 5: EditBook();
                        break;
                    case 6: //ViewMember()
                        break;
                    case 7: //SeatchMember()
                        break;
                    case 8: //AddMember()
                        break;
                    case 9: //RemoveMember()
                        break;
                    case 10: //EditMember()
                        break;
                    case 99:
                        Console.WriteLine("Logging out...");
                        return;
                    default:
                        Console.WriteLine("Wrong selection. Please enter the correct number again!!!");
                        break;
                }

                Console.WriteLine("Do you wish to continue? (y/n)");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y');

        

        }//End of Admin Menu
        public static void ViewBooks()
        {
            foreach (Book bk in books)
            {
                bk.DisplayBook();
            }

        }//End of ViewBooks Method

        //AddBook Method
        public static void AddBook()
        {
            Console.WriteLine("Enter the Book ID you would like to add. (example: ab1234)");
            string bookIDEntered = Console.ReadLine();

            Console.WriteLine("Enter the title of the book you would like to add.");
            string bookTitleEntered = Console.ReadLine();

            Console.WriteLine("Enter the Author of the book you would like to add.");
            string bookAuthorEntered = Console.ReadLine();

            Console.WriteLine("Enter the established year of the book.");
            int yearEstablishedEntered = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of copies available.");
            int copiesEntered = Convert.ToInt32(Console.ReadLine());

            Book newBook = new Book(
                bookIDEntered,
                bookTitleEntered,
                bookAuthorEntered,
                yearEstablishedEntered,
                copiesEntered
            );

            books.Add(newBook);

            Console.WriteLine();
            Console.WriteLine($"You have successfully added {bookIDEntered} - {bookTitleEntered} ({copiesEntered} copies available).");
        }//End of AddBook Method

        //RemoveBook Method
        public static void RemoveBook()
        {
            Console.Write("Enter the Book ID to remove: ");
            string bookIDRemove = Console.ReadLine();

            Book bookRemove = books.Find(b => b.BookID.Equals(bookIDRemove, StringComparison.OrdinalIgnoreCase));

            if (bookRemove != null)
            {
                bookRemove.DisplayBook();

                Console.Write("\nAre you sure you want to delete this book? (y/n): ");
                char confirm = Convert.ToChar(Console.ReadLine());

                if (confirm == 'y' || confirm == 'Y')
                {
                    books.Remove(bookRemove);

                    Console.WriteLine("Book successfully removed.");
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                }
            }
            else
            {
                Console.WriteLine($"Book {bookIDRemove} was not found.");
            }
        }//End of RemoveBook Method

        //EditBook Method
        public static void EditBook()
        {
            Console.Write("Enter the Book ID to edit: ");
            string bookIDEdit = Console.ReadLine();

            Book bookEdit = books.Find(b => b.BookID.Equals(bookIDEdit, StringComparison.OrdinalIgnoreCase));

            if (bookEdit != null)
            {
                Console.WriteLine("\nCurrent Book Details:");
                bookEdit.DisplayBook();

                Console.WriteLine("\nEnter New Book Title:");
                bookEdit.BookTitle = Console.ReadLine();

                Console.WriteLine("Enter New Author:");
                bookEdit.Author = Console.ReadLine();

                Console.WriteLine("Enter New Year Established:");
                bookEdit.YearEstablished =
                    Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter New Number of Copies:");
                bookEdit.NumberOfCopies =
                    Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nBook details updated successfully.");

                Console.WriteLine("\nUpdated Book Details:");
                bookEdit.DisplayBook();
            }
            else
            {
                Console.WriteLine(
                    $"Book {bookIDEdit} was not found.");
            }
        }//End of EditBook Method

        //SearchBook Method
        public static void SearchBook()
        {
            Console.WriteLine("Enter the book ID that you would like to remove from the library (example: ab1234).");
            string bookIDSearch = Console.ReadLine();

            Book bookSearch = books.Find(e=> e.BookID.Equals( bookIDSearch, StringComparison.OrdinalIgnoreCase));
            if (bookSearch != null)
            {
                Console.WriteLine($"Book {bookIDSearch} is found in the list");

                bookSearch.DisplayBook();
               
            }
            else
                Console.WriteLine($"Book {bookIDSearch} is not in the list");

        }//End of SearchBook Method

        //BorrowBook Method
        public static void BorrowBook()
        {
            Console.Write("Enter Member ID: ");
            string memberID = Console.ReadLine();

            Console.Write("Enter Book ID: ");
            string bookID = Console.ReadLine();

            Book book = books.Find(b => b.BookID.Equals(bookID, StringComparison.OrdinalIgnoreCase));

            if (book != null)
            {
                if (book.NumberOfCopies > 0)
                {
                    book.BorrowBook();

                    Transaction newTransaction =
                        new Transaction(
                            "T" + (transactions.Count + 1),
                            bookID,
                            memberID,
                            "Borrow"
                        );

                    transactions.Add(newTransaction);

                    Console.WriteLine("Transaction recorded.");
                }
                else
                {
                    Console.WriteLine("No copies available.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }//End of BorrowBook Method

        //ReturnBook Method
        public static void ReturnBook()
        {
            Console.Write("Enter Member ID: ");
            string memberID = Console.ReadLine();

            Console.Write("Enter Book ID: ");
            string bookID = Console.ReadLine();

            Book book = books.Find(b => b.BookID.Equals(bookID, StringComparison.OrdinalIgnoreCase));

            if (book != null)
            {
                book.ReturnBook();

                Transaction newTransaction =
                    new Transaction(
                        "T" + (transactions.Count + 1),
                        bookID,
                        memberID,
                        "Return"
                    );

                transactions.Add(newTransaction);

                Console.WriteLine("Return transaction recorded.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }//End of ReturnBook Method

    }//End of Program
}//End of namespace
