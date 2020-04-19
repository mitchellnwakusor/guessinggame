using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int level;
            int randomNumber;
            int userGuess;
            int lives;
           // Console.WriteLine(randomnumber);
            Console.WriteLine("Welcome to Guess that Number, Choose a level, 1 - for easy level, 2 - for medium, 3 - for hard ");
            level = int.Parse(Console.ReadLine());
            if(level == 1){
                lives = 6;
                Random rnd = new Random();
                randomNumber = rnd.Next(1,10);
                
                while(lives > 0 ){
                Console.Write("Welcome to level 1, You can now guess a number between 1 and 10 ");
                userGuess = int.Parse(Console.ReadLine());
                if(userGuess == randomNumber){
                    Console.WriteLine("Congratulations you guessed right");
                    break;
                }
                else if(userGuess != randomNumber){
                    lives--;
                    Console.WriteLine("Sorry you guessed wrong");
                    Console.WriteLine("You have " + lives + " lives remaining");
                    if(lives == 0){
                        Console.WriteLine(" GAME OVER");
                    }
                }
                }
            }
            else if(level == 2){
                    lives = 4;
                Random rnd = new Random();
                randomNumber = rnd.Next(1,20);
                
                while(lives > 0 ){
                Console.Write("Welcome to level 2, You can now guess a number between 1 and 20 ");
                userGuess = int.Parse(Console.ReadLine());
                if(userGuess == randomNumber){
                    Console.WriteLine("Congratulations you guessed right");
                    break;
                }
                else if(userGuess != randomNumber){
                    lives--;
                    Console.WriteLine("Sorry you guessed wrong");
                    Console.WriteLine("You have " + lives + " lives remaining");
                    if(lives == 0){
                        Console.WriteLine(" GAME OVER");
                    }
                }
                }
            }
            else if(level == 3){
                    lives = 3;
                Random rnd = new Random();
                randomNumber = rnd.Next(1,50);
                
                while(lives > 0 ){
                Console.Write("Welcome to level 3, You can now guess a number between 1 and 50 ");
                userGuess = int.Parse(Console.ReadLine());
                if(userGuess == randomNumber){
                    Console.WriteLine("Congratulations you guessed right");
                    break;
                }
                else if(userGuess != randomNumber){
                    lives--;
                    Console.WriteLine("Sorry you guessed wrong");
                    Console.WriteLine("You have " + lives + " lives remaining");
                    if(lives == 0){
                        Console.WriteLine(" GAME OVER");
                    }
                }
                }
            }
            else{
                Console.WriteLine("Please type in either 1,2 or 3");
            }
            
        }
    }
}
