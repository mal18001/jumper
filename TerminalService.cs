namespace jumper.Game
{
    /// The responsibility of a TerminalService is to provide input and output operations for the terminal.

    public class TerminalService
    {
        /// Constructs a new instance of TerminalService.
        public TerminalService()
        {
            
        }
        /// Gets text input from the terminal. Directs the user with the given prompt.
        /// <returns>Inputted text.
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// Displays the given text on the terminal. 
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
