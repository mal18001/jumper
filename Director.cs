namespace jumper.Game
{
    public class Director
    {
        private bool _isPlaying = true;
        private TerminalService terminalService = new TerminalService();
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
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
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            terminalService.WriteText("");

            
            _isPlaying = false;

        }
    }
}
