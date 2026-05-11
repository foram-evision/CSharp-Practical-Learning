namespace StudentManagementSystem.Models
{
    public class Student
    {
        // Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Course { get; set; }

        // Constructor
        public Student(int id, string name, int age, string course)
        {
            Id = id;
            Name = name;
            Age = age;
            Course = course;
        }

        // Method
        public void DisplayStudent()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine("---------------------------");
        }
    }
}