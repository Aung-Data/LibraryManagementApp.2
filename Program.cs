namespace LibraryManagementApp._2
{
    internal class Program
    {
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
                        Console.WriteLine("Exiting application...");
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
                    case 1: //ViewBooks()
                        break;
                    case 2: //SearchBook()
                        break;
                    case 3: //BorrowBook()
                        break;
                    case 4: //ReturnBook()
                        break;
                    case 99:
                        Console.WriteLine("Thank you for using the application. Goodbye!!!");
                        Environment.Exit(0);
                        break;
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
                    case 1: //ViewBooks()
                        break;
                    case 2: //SearchBook()
                        break;
                    case 3: //AddBook()
                        break;
                    case 4: //RemoveBook()
                        break;
                    case 5: //EditBook()
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
                        Console.WriteLine("Thank you for using the application. Goodbye!!!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong selection. Please enter the correct number again!!!");
                        break;
                }

                Console.WriteLine("Do you wish to continue? (y/n)");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y');


        }//End of Admin Menu

    }//End of Program
}//End of namespace
