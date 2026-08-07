using System;
using System.Collections.Generic;
using System.Text;

namespace A01;

class FileContainingMainMethodAndSwitchCase
{
    public static void Main(string[] args)
    {   Console.WriteLine("Select a number that corresponds to the desired option:");
        Console.WriteLine("1-Guessing Game : Academy1");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice) {
            case 1:
                Academy1.academy1();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
     
}
