﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataMgmt.Core
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Name(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return "FirstName : \t" + FirstName.ToString() + "\nLastName\t : " + LastName.ToString();
        }
    }
}
