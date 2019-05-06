using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AbelAndColeCore.Utils;

namespace AbelAndColeCore.Entities
{
    

    public class Person
    {
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Value> Preferences { get; set; }

        public Person(string pName, string pEmail)
        {
            Name = pName;
            Email = pEmail;
            Preferences = new List<Value>();
        }

        public Person(int pid,string pName, string pEmail, List<Value> pPreferences)
        {
            IdPerson = pid;
            Name = pName;
            Email = pEmail;
            Preferences = pPreferences;
        }

       
    }
}
