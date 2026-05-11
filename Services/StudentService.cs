using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        // Add Student
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student Added Successfully");
        }

        // View Students
        public void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No Students Found");
                return;
            }

            foreach (var student in students)
            {
                student.DisplayStudent();
            }
        }

        // Search Student
        public void SearchStudent(int id)
        {
            var student = students.Find(s => s.Id == id);

            if (student != null)
            {
                student.DisplayStudent();
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        // Delete Student
        public void DeleteStudent(int id)
        {
            var student = students.Find(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }
    }
}