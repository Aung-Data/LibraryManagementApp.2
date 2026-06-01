using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp._2
{
    public class Member
    {
        //Member class field
        private int memberID;
        private string memberFirstName;
        private string memberLastName;
        private string memberEmail;       
        private string memberPhone;

        //Member Class Properties
        public int MemberID {  get { return memberID; } set { memberID = value; } }
        public string MemberFirstName {  get { return memberFirstName; } set { memberFirstName = value; } }
        public string MemberLastName { get { return memberLastName; } set { memberLastName = value;  } }
        public string MemberEmail { get { return memberEmail; } set { memberEmail = value; } }   
        public string MemberPhone { get { return memberPhone; } set { memberPhone = value; } }

        //Member Class Constructors
        public Member(int id, string fn, string ln, string em, string ph)         
        {
            MemberID = id;
            MemberFirstName= fn;
            MemberLastName = ln;
            MemberEmail = em;        
            MemberPhone = ph;

        }

        //Member Class Methods
        //DisplayMember Method

        public void DisplayMember()
        {
            Console.WriteLine("==========Member Details==========");
            Console.WriteLine("==================================");
            Console.WriteLine($"Member ID:\t\t{MemberID}");
            Console.WriteLine($"First Name:\t\t{MemberFirstName}");
            Console.WriteLine($"Last Name:\t\t{MemberLastName}");
            Console.WriteLine($"Email:\t\t\t{MemberEmail}");
            Console.WriteLine($"Phone:\t\t\t{MemberPhone}");
            Console.WriteLine("==================================");

        }





    }//End of class
}//End of namespace
