namespace T01_Calculate_Average_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            double grades = 0;

            for (int i = 1; i <= studentCount; i++)
            {

                double grade = double.Parse(Console.ReadLine());
                grades += grade;
            }

            double averageGrade = grades / studentCount;

            Console.WriteLine($"{averageGrade:F2}");
        }
    }
}