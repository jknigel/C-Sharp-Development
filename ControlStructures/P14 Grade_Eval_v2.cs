public class Program14
{
    public static void Run()
    {
        int[] scores = [95, 82, 67, 45, 76];

        for (int i = 0; i < scores.Length; i++)
        {
            char grade;

            if (scores[i] >= 90)
            {
                grade = 'A';
            }
            else if (scores[i] >= 80)
            {
                grade = 'B';
            }
            else if (scores[i] >= 70)
            {
                grade = 'C';
            }
            else if (scores[i] >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"Score: {scores[i]} - Grade: {grade}");
        }
    }
}