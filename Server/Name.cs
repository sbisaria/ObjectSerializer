namespace ObjectMgmt.Core
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return "FirstName :\t" + FirstName.ToString() + "\nLastName\t: " + LastName.ToString();
        }
    }
}