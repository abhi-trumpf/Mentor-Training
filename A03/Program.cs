// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program goes through the words in the .txt file and checks if the word contains the letter 'U'
// Program also checks if the word is at least 4 letters long and has some combination of the letters 'U', 'X', 'A', 'L', 'T', 'N', and 'E'.
// It also checks if the word entered by the user is valid or not.
// The program also calculates the score of the word based on its length and whether it is a pangram or not.
// The program checks if the word is valid and calculates its score accordingly.
// ------------------------------------------------------------------------------------------------


using static System.Console;
var path = Path.Combine (AppContext.BaseDirectory, "words.txt");
var grandTotal = 0;
foreach (var word in File.ReadLines (path)) {
   char[] letters = ['U', 'X', 'A', 'L', 'T', 'N', 'E'];
   var isPangram = true;
   if (word.Contains ('U') && word.Length >= 4 && word.All (c => "UXALTNE".Contains (c))) {

      foreach (var letter in letters) {
         if (!word.Contains (letter)) {
            isPangram = false;
            break;
         }
      }
      if (isPangram) {
         WriteLine ($"{word.Length + 7} {word}");
      } else {
         if (word.Length == 4) {
            WriteLine ($"1. {word}");
         } else {
            WriteLine ($"{word.Length}. {word}");
         }
      }
      int score;
      if (word.Length == 4) {
         score = 1;
      } else {
         score = word.Length;
      }
      if (isPangram) {
         score += 7;
      }
      grandTotal += score;
   }
}
WriteLine ($"----");
WriteLine ($"Grand total score: {grandTotal}");
