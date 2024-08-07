namespace WebApplication1.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }

    }
}
