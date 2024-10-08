using Gradebook_Giannuzzi;
using System.Linq;

class Program
{
    public
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome");
        Console.WriteLine("Enter the amount of tests each student took");
        string testString = Console.ReadLine();

       
        if (int.TryParse(testString, out int testAmount))
        {
            if (testAmount <= 5 && testAmount > 0)
            {
                
                List<Student> students = Student.GenerateMockStudents();
                List<string> results = new List<string>();
                foreach (var student in students)
                {
                    Console.WriteLine($"Enter test scores for {student.FirstName} {student.LastName}:");

                    int[] testScores = new int[testAmount];
                    for (int i = 0; i < testAmount; i++)
                    {
                        Console.Write($"Test {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
                        {
                            testScores[i] = score;
                          
                        }
                        else
                        {
                            Console.WriteLine("Error: Enter a valid integer between 0 and 100.");
                            Console.WriteLine("Press any key to exit");
                            Console.ReadKey();
                            return;
                        }

                       
                    }

                    double finalGrade = CalculateFinalGrade(testScores);
                    student.FinalGrade = finalGrade;
                    results.Add($"{student.FirstName} {student.LastName, -20}{student.FinalGrade:f2}");

                   
                }
                Console.WriteLine("\n Student               Grade ");
                foreach(var result in results)
                {
                    Console.WriteLine(result);
                }

            }
            else
            {
                    Console.WriteLine("Error: Enter a number of students between 1 and 5");
                
                
            }
            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
        static double CalculateFinalGrade(int[] testScores)
        {
            double average = testScores.Average();
            return average;
        }
    }
}