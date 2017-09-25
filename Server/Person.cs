using System;

namespace ObjectMgmt.Core
{
    public  class Person
    {
        public Name FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "Name" + FullName.ToString() + "\n Date Of Birth\t" + DateOfBirth.ToString() + "\nAge:\t" + Age.ToString();

        }
    }
}