using System;
using System.Collections.Generic;
using System.IO;


namespace CodeSample
{
    class GuessingGame : GuessingGameBase
    {
        
        public GuessingGame(int minimum, int maximum, int number) : base(minimum, maximum, number) { }//end GuessingGame()

        /// <summary>
        /// Using only the information you have access to in gameState, return 
        /// the number for the next guess. After each guess, you will know 
        /// whether the guess was High, Low, or Correct. 
        /// 
        /// Modify this method and add any methods you may need.
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns>The next guess.</returns>
        /// 
        public static int next;
        public static int NextGuess(GuessingGame gameState)
        {
            
            Console.WriteLine(gameState.State);

            if (gameState.State == Hint.Low)
            {
                
                //if the current guess is too low it finds the mid number between the guess and Max
                next = (gameState.CurrentGuess + gameState.Maximum) / 2;
                //sets the new Min and narrows the range of numbers to choose from
                gameState.Minimum = gameState.CurrentGuess;
               
            }
            else if (gameState.State == Hint.High)
            {
                
                //if the current guess is too high it finds the mid number between the guess and Min             
                next = (gameState.CurrentGuess + gameState.Minimum) / 2;
                //sets the new Max and narrows the range of numbers to choose from
                gameState.Maximum = gameState.CurrentGuess;
                
            }

            return next;
          
                
         }//end NextGuess()


    }//end class GuessingGame






    class JumpToConclusions : JumpToConclusionsBase
    {
        

        public JumpToConclusions(int[] gameBoard) : base(gameBoard) { }//end JumpToConclusion()

        /// <summary>
        /// Find the smallest cost to move to the end of the array. The cost is 
        /// calculated by adding the value of each element on your path to the 
        /// end of the array. Starting at position 0, reach the end of the array 
        /// by executing a sequence of moves. Each move is either a "step" to 
        /// the next element (current position + 1) or a "jump" to the element 
        /// after that (current position + 2). Arrays will have a length of 1 
        /// or greater.
        /// 
        /// For example, if GameBoard is {1, 5, 2, 7, 22, 14, 8, 9}, 
        /// the smallest cost is 33 by moving to positions 0, 2, 3, 5, and 7.
        ///     GameBoard[0] + GameBoard[2] + GameBoard[3] + GameBoard[5] + GameBoard[7] == 33
        /// 
        /// Modify this method and add any methods you may need.
        /// </summary>
        /// <returns>The cost.</returns>
        public override int CalculateCost()
        {
            int total = 0;
            int i = 0;
           

            for (i = 0 ; i < GameBoard.Length; i++)
            {

                for (int j = 0; j < GameBoard.Length; j+= 2)
                {

                }//end j loop

            }//end i loop


            //int i = 0;
            //int currentIndex = i;
            //int prev;
            //int step = GameBoard[i + 1];
            //int jump = GameBoard[i + 2];
            //int total = GameBoard[0];
            //int arrayLength = GameBoard.Length;

            //try
            //{
            //    while (i < arrayLength)
            //    {
            //        if (step <= jump)
            //        {
            //            total = total + GameBoard[jump];
            //            currentIndex = currentIndex + 2;
            //            i = i + 2;
            //            //nextMove = false;
            //        }
            //        else
            //            total = total + GameBoard[step];
            //        currentIndex = currentIndex + 1;
            //        i = i + 1;

            //    }//end while loop
            //}//ent try
            //catch (System.IndexOutOfRangeException e) { }
            return total; 
            
        }//end CalculateCost()

        //private int Step(int x)
        //{
        //    int step = x + 1;

        //    return step;
        //}//end Step()

        //private int Jump(int x)
        //{
        //    int jump = x + 2;

        //    return jump;
        //}//end Step()

    }//end class JumpToConclusions









    class WordCounter : WordCounterBase
    {
        public WordCounter(StreamReader inputStream, StreamWriter outputStream) : base(inputStream, outputStream) { }

        /// <summary>
        /// Return a list of WordEntry objects, one for each unique word. Each 
        /// WordEntry object in the list should contain word and the correct 
        /// count of occurences of that word in the appropriate properties.
        /// 
        /// Modify this method and add any methods you may need.
        /// </summary>
        /// <returns>An IEnumerable of WordEntry objects with the counts calculated.</returns>
        public override IEnumerable<WordEntry> GetWordCount()
        {
            throw new NotImplementedException();
        }
    }
}
