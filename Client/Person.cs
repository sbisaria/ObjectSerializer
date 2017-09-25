using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataMgmt.Core
{
    public class Person
    {
        public Name FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        //public string MobileNo { get; set; }

        //public Person(Name name,DateTime dob,int age,string mobileNo)
        //{ 

        //}
        public override string ToString()
        {
            return "Name \t" + FullName.ToString() + "\n Date Of Birth\t" + DateOfBirth.ToString() + "\nAge\t" + Age;

        }
    }
}
