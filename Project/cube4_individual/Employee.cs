namespace CompanyDirectoryApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FixedPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int ServiceId { get; set; }
        public int LocationId { get; set; }
        public string ServiceName { get; set; } // To display in the data grid
        public string Location { get; set; } // To display in the data grid
    }
}
