namespace jumper.Game
{
    public class Word
    {
        private String randomWord;
        private String playerGuess;

        public Word(){
            playerGuess = "";
            randomWord = "";
        }

        public void setPlayerGuess(String guess){
            playerGuess = guess;
        }
    }
}