using System;

namespace CodeSample
{
    class JumpToConclusionsBase
    {
        public int[] GameBoard { get; set; }

        public JumpToConclusionsBase(int[] gameBoard)
        {
            GameBoard = gameBoard;
        }

        public virtual int CalculateCost()
        {
           
            throw new NotImplementedException();
        }
    }
}
