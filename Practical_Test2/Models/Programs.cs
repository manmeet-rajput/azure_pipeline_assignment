namespace Practical_Test2.Models
{
    public class Programs
    {
        public int ProgramID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        // Foreign key reference to Student table
        public ICollection<Student> Students { get; set; }
    }
}
