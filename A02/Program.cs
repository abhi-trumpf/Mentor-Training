// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program used to create a word from specific letters and calculate its score based on specific rules.
// The program checks if the word is valid and calculates its score accordingly.
// ------------------------------------------------------------------------------------------------

using System;
using System.IO;

public class Program {
   public static void Main (string[] args) {
      char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };

      string[] validWords = File.ReadAllLines ("words.txt");

      Console.WriteLine ("Enter a word to check if it's valid and calculate its score:");
      string word = (Console.ReadLine () ?? "").Trim ().ToUpper ();

      bool wordExists = false;

      foreach (string fileWord in validWords) {
         if (fileWord.Trim ().ToUpper () == word) {
            wordExists = true;
            break;
         }
      }

      if (!wordExists) {
         Console.WriteLine ("Word is not in words.txt.");
      } else if (word.Length < 4) {
         Console.WriteLine ("Invalid word. Must be at least 4 letters long.");
      } else if (!word.Contains ('U')) {
         Console.WriteLine ("Word is invalid. Must contain the letter 'U'.");
      } else if (word.Length == 4) {
         Console.WriteLine ("Word is valid. Score: 1");
      } else {
         bool isPangram = true;

         foreach (char letter in letters) {
            if (!word.Contains (letter)) {
               isPangram = false;
               break;
            }
         }

         if (isPangram)
            Console.WriteLine ($"Word is valid and a pangram. Score: {word.Length + 7}");
         else
            Console.WriteLine ($"Word is valid. Score: {word.Length}");
      }
   }
}
