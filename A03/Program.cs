// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program goes through the words in the .txt file and checks if the word contains the required
// letters, Programs checks if it is valid and highlights the word in green if it is a pangram and
// prints the score of the word
// ------------------------------------------------------------------------------------------------
using static System.Console;

string[] words = File.ReadAllLines ("words.txt");
char[] letters = ['U', 'X', 'A', 'L', 'T', 'N', 'E'];
Dictionary<string, (int Score, bool IsGuessed)> gameTracker = [];
const int minLength = 4;
int total = 0;
foreach (var word in words)
   if (IsValid (word))
      CalculateScore (word);
DisplayOutput ();

// Display the value and key pair
void DisplayOutput () {
   foreach (var (value,word) in gameTracker.OrderByDescending (x => x.Value.Score)) {
      if (gameTracker[value].IsGuessed)
         ForegroundColor = ConsoleColor.Green;
      WriteLine ($"{word.Score,2}. {value}"); //deconstruction
      ResetColor ();
   }
   WriteLine ($"- - - -\n{total} total");
}

// Calculates the score of the word and adds it to the total score
void CalculateScore (string word) {
   bool isGuessed = letters.All (word.Contains);
   int score = word.Length == minLength ? 1 : word.Length;
   if (isGuessed)
      score += 7;
   gameTracker[word] = (score, isGuessed);
   total += score;
}

// Checks if the word is valid based on the length and returns a boolean value
bool IsValid (string word) => word.Length >= minLength && word.Contains (letters[0]) && word.All (letters.Contains);