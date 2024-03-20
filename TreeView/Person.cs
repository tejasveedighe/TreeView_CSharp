namespace Views
{
    class Person
    {
        public Person()
        {
            Id = new Random().Next(1, 1000);
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DOB { get; set; }

    }
}