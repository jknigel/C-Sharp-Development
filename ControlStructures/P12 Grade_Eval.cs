public class Program12
{
    public static void Run()
    {
        int[] scores = [95, 82, 67, 45, 76];

        for (int i = 0; i < scores.Length; i++)
        {
            string result;

            if (scores[i] >= 65)
            {
                result = "Pass";
            }
            else
            {
                result = "Fail";
            }
            Console.WriteLine($"Score: {scores[i]} - Result: {result}");
        }
    }
}