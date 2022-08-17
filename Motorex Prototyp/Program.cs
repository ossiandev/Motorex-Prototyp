using System;
using System.Collections.Generic;

//setup global
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
    private float points = 0;
    
}



class Program 
{
    public static void Main()
    {
        //setup local
        string fullPath = Path.GetFullPath("savedNames.txt"); // filepath for savedNames.txt
        IDictionary<string, string> logInPairs = new Dictionary<string, string>(); // hashmap used for logins
        StreamWriter streamWriter = new StreamWriter(fullPath); //used for saving and loading usernames, challenges etc.
        streamWriter.WriteLine("hello!");
        List<Challenge> tasks = new List<Challenge> ();
        tasks.Add(new Challenge(20, "Walk A Bunch!", "Walk 10,000 steps!"));
        List<User> users = new List<User> ();
        
        //start
        Console.WriteLine("Welcome to Motorex Daily Challenge App\n\n");
        Console.WriteLine("1. Receive Daily Challenge\n");
        Console.WriteLine("2. Leaderboards\n");
        Console.WriteLine("3. Review Previous Challenges\n");
        Console.WriteLine("4. Exit App\n");
        start:
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1://Daily challenge
                Console.WriteLine("Your DAILY CHALLENGE IS: \n\n**********\n\n");

                break;

            case 2://leaderboards friends and global add friends 
                Console.WriteLine("Leaderboards \n\n 1. Friend Leaderboard \n\n 2. Global Leaderboard");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Friend Leaderboard");
                        int counter = 0;
                        foreach (Object user in users )
                        {
                            Console.WriteLine(users);
                            counter++;

                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        if(Console.ReadLine() == "3.")
                        {
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                }
                break;

            case 3://review previous
                Console.WriteLine();
                break;

            case 4://exit program
                Console.WriteLine();
                Console.ReadKey();
                return;
            default:
                goto start;

        }




    }
}