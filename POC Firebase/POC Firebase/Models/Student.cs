namespace POC_Firebase.Models
{
    public class Student
    {
        public string? Id { get; set; } // firebase unique id
        public string? Student_id { get; set; }
        public string? Fullname { get; set; }
        public string? DegreeTitle { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
