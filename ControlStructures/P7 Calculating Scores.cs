public class Program7
{
    public static void Run()
    {
        int[] scores = [85, 90, 78, 92, 88];

        int final_score = 0;

        for (int i = 0; i < scores.Length; i++) {
            final_score += scores[i];
        }

        Console.WriteLine("The total score is " + final_score);
        
    }
}
