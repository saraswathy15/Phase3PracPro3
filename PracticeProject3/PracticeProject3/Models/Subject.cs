namespace PracticeProject3.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string? StudentName { get; set; }

        public string? SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public int SubjectMark { get; set; }
    }
}
