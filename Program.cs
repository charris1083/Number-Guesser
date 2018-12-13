using System;

//Namwspace
namespace Number_Guesser
{
    //Main CLass
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();// Ru GetAppInfo function to get info

            GreetUser(); // ask for user name and greet


            while (true)
            {
                //set correct number
                //int correctNumber = 7;

                //create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change txt color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        //tell user its not a number
                        Console.WriteLine("Please enter actual number");

                        //reset txt color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);
                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //change txt color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        //tell user its the wrong number
                        Console.WriteLine("Wrong Number Please Try Again");

                        //reset txt color
                        Console.ResetColor();
                    }


                }

                // output success message
                //change txt color
                Console.ForegroundColor = ConsoleColor.Green;

                //tell user its correct number
                Console.WriteLine("You are correct");

                //reset txt color
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get amnswer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
      
                }
                else if (answer == "N")
                {
                    return;
                }
            }
        }
        // get and display AppInfo
        static void GetAppInfo()
        {

            //set app vars
            string appnName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Cameron Harris";

            //change txt color
            Console.ForegroundColor = ConsoleColor.Cyan;

            
            Console.WriteLine("{0}: Version {1} by {2}", appnName, appVersion, appAuthor);

            //reset txt color
            Console.ResetColor();
        }
        
        //Ask Users name and greet
 
        static void GreetUser()
        {

            // ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }
        
        
            
        
    }
}
