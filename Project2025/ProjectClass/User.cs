using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2025.ProjectClass
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public string Lastname { get; set; }


       public User(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }

    }
}
