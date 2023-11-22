namespace Practical_Test2.Models
{
    public class Repository
    {
        private static List<Student> studentList = new List<Student>();
        public static IEnumerable<Student> AllStudents
        {
            get { return studentList; }
        }
        public static void Create(Student mystudent)
        {
            studentList.Add(mystudent);
        }
    }
}
