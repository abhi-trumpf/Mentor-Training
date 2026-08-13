using System;
using System.Collections.Generic;
using System.Text;

namespace A01;

class Program{
    public static void Run () {
        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("The range limit for the number to be guessed is between 1 and 100");
        int randomNumber = new Random().Next(1, 101);  //generates a random number between 1 and 100 does not include 101
        while (true){
            Console.WriteLine("Enter your guess:");
            if(!int.TryParse(Console.ReadLine(), out int guess)){
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }
            if(guess < randomNumber)
                Console.WriteLine("Your guess is too low");
            else if(guess > randomNumber)
                Console.WriteLine("Your guess is too high");
            else{
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }

    public static void Main(string[] args){
        Run ();
    }
}
