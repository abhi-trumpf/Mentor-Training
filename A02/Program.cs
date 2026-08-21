// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program used to create a word from specific letters and calculate its score based on specific rules.
// The program checks if the word is valid and calculates its score accordingly.
// ------------------------------------------------------------------------------------------------

public class Program {
   public static void Main (string[] args) {
      char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
      Console.WriteLine ("Enter a word to check if it's valid and calculate its score:");
      string word = Console.ReadLine ().ToUpper () ?? "";
      if (word.Length < 4) {
         Console.WriteLine ("Invalid word. Must be at least 4 letters long.");
      } else {
         if (word.Contains ('U')) {             //has to have u
            if (word.Length == 4) {
               Console.WriteLine ("Word is valid. Score: 1");
            } else if (word.Length > 4 && word.Length < 7) {
               Console.WriteLine ($"Word is valid. Score: {word.Length}");
            } else if (word.Length >= 7) {
               bool isPangram = true;
               foreach (char letter in letters) {
                  if (!word.Contains (letter)) {  // calculates whether the word contains all the required letters atleast once
                     isPangram = false;
                     break;
                  }
               }
               if (isPangram)
                  Console.WriteLine ($"Word is valid and a panagram. Score: {word.Length + 7}");
               else
                  Console.WriteLine ($"Word is valid. Score: {word.Length}");

            }
         } else {
            Console.WriteLine ("Word is invalid. Must contain the letter 'u'.");
         }
      }
   }
}

