public class Program9
{
    public static void Run()
    {
        int[] studentScores = [45, 60, 72, 38, 55];

        for (int i=0; i<studentScores.Length; i++) {
            if (studentScores[i] >= 50) {
                Console.WriteLine("Pass");
            } else {
                Console.WriteLine("Fail");
            }
        }
    }
}