// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program goes through the words in the .txt file and checks if the word contains the required letters
// Programs checks if it is valid and highlights the word in green if it is a pangram and prints the score of the word
// ------------------------------------------------------------------------------------------------

public class Project1 {
   string[] lines = File.ReadAllLines ("words.txt");
   char[] letters = ['U', 'X', 'A', 'L', 'T', 'N', 'E'];
   Dictionary<string, int> myDictionary = new ();
   int grandTotal = 0;
   //for (int i = 0; i < lines.Length; i++)  //lines - total number of lines in the file.
   public void IsValid () {
      foreach (var line in lines) {
         string word = line.ToUpper ();  //converts to cap U
         if (word.Contains ("U") && word.Length >= 4 && word.All (letters.Contains)) //check for U
         {
            int score = line.Length == 4 ? 1 : line.Length; // '=' = if
            myDictionary[line] = score;
         }
      }
   }
   public void IsPangram () {
      foreach (var key in myDictionary.Keys.ToList ()) {
         string word = key.ToUpper ();
         if (letters.All (c => word.Contains (char.ToUpper (c)))) //only access the ones that have value
         {
            myDictionary[key] += 7;
         }
      }
   }
   public void PrintKeyValuePairs () {
      foreach (var item in myDictionary.OrderByDescending (x => x.Value)) {
         string word = item.Key.ToUpper (); //toUpper()
         bool isPangram = letters.All (word.Contains); //check if pangram
         if (isPangram) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ($"{item.Value}. {item.Key}");
            Console.ResetColor ();
            grandTotal += item.Value;
         } else {
            Console.WriteLine ($"{item.Value}. {item.Key}");
            grandTotal += item.Value;
         }
      }
      Console.WriteLine ("- - - -");
      Console.WriteLine ($"{grandTotal} total");
   }
   public static void Main (string[] args) {
      Project1 p = new Project1 ();
      p.IsValid ();
      p.IsPangram ();
      p.PrintKeyValuePairs ();
   }
}