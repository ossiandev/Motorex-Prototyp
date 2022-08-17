using System;
using System.Collections.Generic;

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

public class User
{
    private string Name = string.Empty; 
    private int UserId = 0;//add friends through this 
    private float points;
    
}



class Program 
{
    public static void Main(string v)
    {
       string fullPath = Path.GetFullPath(v);
        IDictionary<string, string> logInPairs = new Dictionary<string, string>();
        StreamWriter streamWriter = new StreamWriter(fullPath);
        

        Console.WriteLine("Welcome to Motorex Daily Challenge App\n\n");
        Console.WriteLine("1. Receive Daily Challenge\n");
        Console.WriteLine("2. Leaderboards\n");
        Console.WriteLine("3. Review Previous Challenges\n");
        Console.WriteLine("4. Exit App\n");

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1://Daily challenge
                Console.WriteLine();
                break;

            case 2://leaderboards friends and global add friends 
                Console.WriteLine();
                break;

            case 3://review previous
                Console.WriteLine();
                break;

            case 4://exit program
                Console.WriteLine();
                Console.ReadKey();
                return;

        }




    }
}