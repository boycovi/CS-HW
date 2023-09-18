class Program
{
    static void Main()
    {
        int numberOfSubjects = 3;
        int numberOfGrades = 4;

        int[][] studentGrades = InitializeData(numberOfSubjects, numberOfGrades);

        while (true)
        {
            Console.WriteLine("Select Option:");
            Console.WriteLine("1. Enter new grades");
            Console.WriteLine("2. Calculate average grade");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    studentGrades = EnterGrades(numberOfSubjects, numberOfGrades);
                    break;
                case 2:
                    double averageGrade = CalculateAverageGrade(studentGrades);
                    Console.WriteLine($"Student's average grade is {averageGrade:F2}");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }

    static int[][] InitializeData(int subjects, int grades)
    {
        Random random = new Random();
        int[][] studentGrades = new int[subjects][];
        for (int i = 0; i < subjects; i++)
        {
            studentGrades[i] = new int[grades];
            for (int j = 0; j < grades; j++)
            {
                studentGrades[i][j] = random.Next(1, 11);
            }
        }

        return studentGrades;
    }

    static int[][] EnterGrades(int numberOfSubjects, int numberOfGrades)
    {
        Console.WriteLine("Enter new grades:");

        int[][] studentGrades = new int[numberOfSubjects][];
        for (int i = 0; i < numberOfSubjects; i++)
        {
            studentGrades[i] = new int[numberOfGrades];
            for (int j = 0; j < numberOfGrades; j++)
            {
                Console.Write($"Subject #{i + 1}, grade #{j + 1}: ");
                studentGrades[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return studentGrades;
    }

    static double CalculateAverageGrade(int[][] studentGrades)
    {
        double sum = 0;
        int totalGrades = 0;

        foreach (int[] subjectGrades in studentGrades)
        {
            foreach (int grade in subjectGrades)
            {
                sum += grade;
                totalGrades++;
            }
        }

        if (totalGrades == 0)
        {
            return 0;
        }

        return sum / totalGrades;
    }
}
