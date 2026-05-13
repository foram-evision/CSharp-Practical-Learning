using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

StudentService service = new StudentService();

bool running = true;

while (running)
{
    Console.WriteLine("\n===== Student Management System =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Delete Student");
    Console.WriteLine("5. Exit");

    Console.Write("Enter Choice: ");

    try
    {
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:

                Console.Write("Enter ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                Student student = new Student(id, name, age, course);

                service.AddStudent(student);

                break;

            case 2:

                service.ViewStudents();

                break;

            case 3:

                Console.Write("Enter Student ID: ");

                int searchId = Convert.ToInt32(Console.ReadLine());

                service.SearchStudent(searchId);

                break;

            case 4:

                Console.Write("Enter Student ID: ");

                int deleteId = Convert.ToInt32(Console.ReadLine());

                service.DeleteStudent(deleteId);

                break;

            case 5:

                running = false;

                Console.WriteLine("Application Closed");

                break;

            default:

                Console.WriteLine("Invalid Choice");

                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please Enter Valid Number.............");
        Console.WriteLine("Validation Feature Added");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}