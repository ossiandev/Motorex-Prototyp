using System;


public class Challenge
{
    private float points = 0;
    private string challName = string.Empty;
    private string challTask = string.Empty;

    public Challenge (float points, string challName, string challTask)
    {
        this.points = points;
        this.challName = challName;
        this.challTask = challTask;
    }
}



class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Motorex Daily Challenge App\n\n");
        Console.WriteLine("1. Receive Daily Challenge\n");
        Console.WriteLine("2. Global Leaderboard\n");
        Console.WriteLine("3. Review Previous Challenges\n");
        Console.WriteLine("4. Exit App\n");

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1://Daily challenge
                break;

            case 2://Global leaderboard
                break;

            case 3://review previous
                break;

            case 4://exit program
                return;

        }




    }
}