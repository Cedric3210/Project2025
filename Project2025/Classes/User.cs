using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2025.Classes
{
    public class User
    {
        public int UserId {  get; set; }
        public string FirstName {  get; set; }

        public string LastName { get; set; }

        public User(string fname,string lname,int Uid)
        {
            FirstName = fname;
            LastName = lname;
            UserId = Uid;
        }


        
    }
}
