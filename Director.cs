namespace jumper.Game
{
    public class Director
    {
        private bool _isPlaying = true;
        private TerminalService terminalService = new TerminalService();
        private player player = new player();
        private Word word = new Word();
         /// Constructs a new instance of Director.
        public Director()
        {
        }

        /// Starts the game by running the main game loop.
        public void StartGame()
        {
            while (_isPlaying)
            {
                DoOutputs();
                GetInputs();
                DoUpdates();
            }
        }

        private void GetInputs()
        {
            string guess = terminalService.ReadText("\nGuess a letter [a-z]: ");
            word.setPlayerGuess(guess);
        }

        /// Keeps watch on where the seeker is moving.
        private void DoUpdates()
        {
            
        }

        /// Provides a hint for the seeker to use.
        private void DoOutputs()
        {
            
            _isPlaying = false;

        }
    }
}
