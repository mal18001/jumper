namespace jumper.Game
{
    public class Word
    {
        private String goal_word;
        private String playerGuess;
        Random randomGenerator = new Random();


        public Word()
        {
            playerGuess = "";
            int index = randomGenerator.Next(0, 10);

            List<string> words = new List<string>();

            words.Add("giraffe");
            words.Add("cantaloupe");
            words.Add("prowler");
            words.Add("hurricane");
            words.Add("precipice");
            words.Add("poltergeist");
            words.Add("exponential");
            words.Add("sagebrush");
            words.Add("gazebo");
            words.Add("liberty");

            goal_word = words[index];

            int length = goal_word.Length;

            foreach (char c in goal_word)
            {
                Console.Write(c.ToString());
            }
        }

        public void setPlayerGuess(String guess)
        {
            playerGuess = guess;
        }
    }
}