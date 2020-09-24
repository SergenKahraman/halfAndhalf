namespace halfAndhalf.App.Models
{
    public class Persons
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double TotalPrice { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}