using System;
using System.Collections.Generic;
using System.Text;

namespace A01;

class MenuTracker {
    public static void Main(string[] args) {   
        Console.WriteLine("Select a number that corresponds to the desired option:");
        Console.WriteLine("1-Guessing Game");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice) {
            case 1:
                GuessingGame.RunTheGuessingGame ();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
