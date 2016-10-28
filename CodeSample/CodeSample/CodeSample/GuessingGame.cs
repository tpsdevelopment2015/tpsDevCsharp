namespace CodeSample
{
    abstract class GuessingGameBase
    {
        public enum Hint {High, Low, Correct};
        private readonly int _number;

        public int Minimum { get; protected set; }
        public int Maximum { get; protected set; }
        public int Counter { get; private set; }
        public Hint State { get; private set; }
        public int CurrentGuess { get; private set; }

        public GuessingGameBase(int minimum, int maximum, int number)
        {
            _number = number;
            Minimum = minimum;
            Maximum = maximum;
            CurrentGuess = 0;
            State = Hint.Low;
        }

        public Hint Guess(int number)
        {
            Counter++;
            if (_number == number)
                State = Hint.Correct;
            else if (_number < number)
                State = Hint.High;
            else
                State = Hint.Low;
            CurrentGuess = number;
            return State;
        }
    }
}
