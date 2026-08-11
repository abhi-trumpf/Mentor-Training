using System;
using System.Collections.Generic;
using System.Text;

namespace A01;

class GuessingGame {
    public static void RunTheGuessingGame () {
        int randomGeneratedNumber = new Random().Next(0, 101);  // generates a random number between 0 and 100 does not include 101
        //Console.WriteLine(randomGeneratedNumber);
        bool gameWon = false;
        while (!gameWon) {
            Console.WriteLine("Enter your guess:");
            int guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your guess is {guess}");
            if (guess < randomGeneratedNumber) {
                Console.WriteLine("Your guess is too low");
            }
            else if (guess > randomGeneratedNumber) {
                Console.WriteLine("Your guess is too high");
            }
            else {
                Console.WriteLine("You guessed it!");
                gameWon = true;
            }
        }
    }
}
