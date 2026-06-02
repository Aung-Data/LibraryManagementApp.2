namespace FinalProject
{
    internal class Admin : Login //Admin inherits from Login class 
    {
        // Constructor
        public Admin(string username, string password) : base(username, password) //Calls the base class constructor and forwards its properties.
        { 
        }

        //Display Admin Menu 
        public override string DisplayMenu() //override replaces version Login
        {
            Console.WriteLine("\nAdmin Menu:\n1. Add Book\n2. Remove Book\n3. View all the Books\n4. Search for a Book\n5. Manage Acccount/s\n6. View Library Info\n99. Sign Out");
            return "";
        }
        
    }//end class

}//end namespace
