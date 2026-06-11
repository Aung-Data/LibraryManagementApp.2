using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp._2
{
    public class Member : Person
    {
        //Member class field
        private string memberID;
        private string memberEmail;
        private string memberPhone;

        //Member Class Properties
        public string MemberID { get { return memberID; } set { memberID = value; } }
        public string MemberEmail { get { return memberEmail; } set { memberEmail = value; } }
        public string MemberPhone { get { return memberPhone; } set { memberPhone = value; } }

        //Member Class Constructors
        public Member(string id, string fn, string ln, string em, string ph) : base(fn, ln)
        {
            MemberID = id;
            MemberEmail = em;
            MemberPhone = ph;

        }

        //Polymorphism: override method from Person class
        public override void DisplayDetails()
        {
            Console.WriteLine("========== Member Details ==========");
            Console.WriteLine("====================================");
            Console.WriteLine($"Member ID:\t\t{MemberID}");
            Console.WriteLine($"First Name:\t\t{FirstName}");
            Console.WriteLine($"Last Name:\t\t{LastName}");
            Console.WriteLine($"Email:\t\t\t{MemberEmail}");
            Console.WriteLine($"Phone:\t\t\t{MemberPhone}");
            Console.WriteLine("====================================");
        }

    }//End of class
}//End of namespace