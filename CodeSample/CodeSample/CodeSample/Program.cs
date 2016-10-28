using System;
using System.Diagnostics;
using System.IO;


namespace CodeSample
{
    class Program
    {
        static void Main()
        {
            //TestGuessingGame(1, 100000);
            TestJumpToConclusions(@"..\...\..\jump_to_conclusions_boards.txt");
            //TestWordCounter(@"..\..\..\The_Count_of_Monte_Cristo.txt", @"..\..\..\word_counter_output.csv");

            Console.ReadLine();
        }


        static void TestGuessingGame(int minimum, int maximum)
        {
            Console.WriteLine("Info: Starting TestGuessingGame().");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int guessLimit = 0;
            while (Math.Pow(2, guessLimit) < maximum)
            {
                guessLimit++;
            }

            // Run a game with each valid value.
            for (int i = minimum; i <= maximum; i++)
            {
                 
                GuessingGame game = new GuessingGame(minimum, maximum, i);
                while (game.State != GuessingGame.Hint.Correct)
                {
                    game.Guess(GuessingGame.NextGuess(game));
                }
                Console.Write(String.Format("{0}: {1}\r", i, game.Counter));

                if (game.Counter > guessLimit)
                {
                    Console.WriteLine(String.Format("{0}: {1}", i, game.Counter));
                }
                
            }

            stopwatch.Stop();
            TimeSpan guessingGameTime = stopwatch.Elapsed;

            Console.WriteLine(String.Format("Info: TestGuessingGame() finished. Time: {0}.", guessingGameTime));
        }







        static void TestJumpToConclusions(string inputFileName)
        {
            Console.WriteLine("Info: Starting TestJumpToConclusions().");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (StreamReader reader = new StreamReader(new FileStream(inputFileName, FileMode.Open, FileAccess.Read)))
            {
                string line;

                // Run a test using each line in the input file as a game board.
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(new char[] { ',' });
                    int[] board = new int[values.Length];
                    for (int i = 0; i < board.Length; i++)
                    {
                        board[i] = Convert.ToInt32(values[i]);
                    }
                    JumpToConclusions game = new JumpToConclusions(board);

                    Console.WriteLine(String.Format("{{{0}}}: {1}", line.TrimEnd(), game.CalculateCost()));
                    
                }
            }

            stopwatch.Stop();
            TimeSpan jumpToConclusionsTime = stopwatch.Elapsed;

            Console.WriteLine(String.Format("Info: TestJumpToConclusions() finished. Time: {0}.", jumpToConclusionsTime));
        }












        static void TestWordCounter(string inputFileName, string outputFileName)
        {
            Console.WriteLine("Info: Starting TestWordCounter().");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (StreamReader streamReader = new StreamReader(new FileStream(inputFileName, FileMode.Open, FileAccess.Read)))
            {
                using (StreamWriter streamWriter = new StreamWriter(new FileStream(outputFileName, FileMode.OpenOrCreate)))
                {
                    WordCounterBase wordCounter = new WordCounter(streamReader, streamWriter);
                    wordCounter.Write();
                }
            }

            stopwatch.Stop();
            TimeSpan wordCounterTime = stopwatch.Elapsed;

            Console.WriteLine(String.Format("Info: TestWordCounter() finished. Time: {0}.", wordCounterTime));
        }
    }
}
