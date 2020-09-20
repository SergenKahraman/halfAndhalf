namespace halfAndhalf.App.Models
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public double TotalPrice { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}