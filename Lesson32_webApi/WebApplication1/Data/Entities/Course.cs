namespace WebApplication1.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Duration_months { get; set; }
        public int Price { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }
        public int StudentCount { get; set; }
        public DateTime StartDate { get; set; }


    }
}
