using System;
using System.Collections.Generic;
using System.Text;

namespace A01;

class Academy1
{
    public static void academy1()
    {
        int x = new Random().Next(0, 101);  // generates a random number between 0 and 100 does not include 101
        //Console.WriteLine(x);
        bool state = false;
        while (!state)
        {
            Console.WriteLine("Enter your guess:");
            int guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your guess is {guess}");
            if (guess < x)
            {
                Console.WriteLine("Your guess is too low");
            }
            else if (guess > x)
            {
                Console.WriteLine("Your guess is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                state = true;
            }
        }

    }
}
