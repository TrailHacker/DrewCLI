using System;
using System.IO;

namespace Drew_CLI {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Please enter the word you would like to replace: ");
            var wordToFind = Console.ReadLine();

            Console.WriteLine ("Please enter the word you would like to replace it with: ");
            var wordToReplace = Console.ReadLine();

            try {
                using var reader = new StreamReader ("input.txt");
                using var writer = new StreamWriter ("ouptput.txt");

                string line = null;
                while ((line = reader.ReadLine ()) != null) {
                    line = line.Replace (wordToFind, wordToReplace);
                    writer.WriteLine (line);
                }
            } catch (FileNotFoundException oopsNotFound) {
                Console.WriteLine ("File not found! Details: " + oopsNotFound.Message);
            }

        }
    }
}