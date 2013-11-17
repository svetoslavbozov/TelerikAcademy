
namespace _03.SortStudentsAlphabetically
{
    public class Students
    {
        private string firstName;

        private string lastName;

        public Students(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        
    }
}
