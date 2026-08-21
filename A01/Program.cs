// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program used to make the user guess a random number between 1 and 100. The user has to guess the number correctly, and the program will provide feedback on whether the guess is too low or too high. 
// The program continues until the user guesses the correct number.
// ------------------------------------------------------------------------------------------------
namespace A01;

class Program {
   public static void Main () {
      Console.WriteLine ("Welcome to the number guessing game!\nThe range limit for the number to be guessed is between 1 and 100");
      int randomNumber = new Random ().Next (1, 101);  // generates a random number between 1 and 100 does not include 101
      while (true) {
         Console.Write ("Enter your guess: ");
         if (!int.TryParse (Console.ReadLine (), out int guess) || guess < 1 || guess > 100) {
            Console.WriteLine ("Invalid input. Please enter a valid integer between 1 and 100.");
            continue;
         }
         if (guess < randomNumber) Console.WriteLine ("Your guess is too low");
         else if (guess > randomNumber) Console.WriteLine ("Your guess is too high");
         else {
            Console.WriteLine ("You guessed it!");
            break;
         }
      }
   }
}
