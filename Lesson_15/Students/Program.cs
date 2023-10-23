namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
            new Student { Name = "Olena", Grade = 95, Course = 1 },
            new Student { Name = "Petro", Grade = 88, Course = 2 },
            new Student { Name = "Timofy", Grade = 94, Course = 2 },
            new Student { Name = "Anna", Grade = 92, Course = 1 },
            new Student { Name = "Mykita", Grade = 78, Course = 3 },
            new Student { Name = "Irina", Grade = 90, Course = 2 },
            new Student { Name = "Andriy", Grade = 91, Course = 3 },
            };
            //1
            List<Student> highestScore = students.Where(p => p.Grade >= 90).ToList();
            Console.WriteLine("Students with highest scores:\n");
            foreach (Student student in highestScore)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //2
            List<Student> descendingOrder = students.OrderByDescending(p => p.Grade).ToList();
            Console.WriteLine("Descending order of student by grade:\n");
            foreach (Student student in descendingOrder)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //3
            List<Student> firstCourse = students.Where(p => p.Course == 1).ToList();
            List<Student> secondCourse = students.Where(p => p.Course == 2).ToList();
            List<Student> thirdCourse = students.Where(p => p.Course == 3).ToList();
            Console.WriteLine("Student of the first course:\n");
            foreach (Student student in firstCourse)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Student of the second course:\n");
            foreach (Student student in secondCourse)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Student of the third course:\n");
            foreach (Student student in thirdCourse)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();

            //4
            int firstCourseStudentCount = students.Count(p => p.Course == 1);
            int secondCourseStudentCount = students.Count(p => p.Course == 2);
            int thirdCourseStudentCount = students.Count(p => p.Course == 3);
            Console.WriteLine($"Total students at first course:{firstCourseStudentCount}");
            Console.WriteLine($"Total students at second course:{secondCourseStudentCount}");
            Console.WriteLine($"Total students at third course:{thirdCourseStudentCount}");
            Console.WriteLine();

            //5
            var studentInfo = students.Select(student => $"Name: {student.Name}, Grade: {student.Grade}");
            foreach (var info in studentInfo)
            {
                Console.WriteLine(info);
            }
            Console.ReadKey();
        }
    }
}