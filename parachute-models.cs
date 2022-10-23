namespace jumper.Game
{
    public class player
    {
        public static player decide = new player();

        private int total_lives = 4;
        private bool correct;
        public void models()
        {
            string full_parachute = "\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n \\       \\                /       /\n   \\      \\              /      /\n     \\     \\            /     /\n       \\    \\          /    /\n         \\   \\        /   /\n           \\  \\      /  /\n             \\ \\    / /\n               \\\\  //\n               _.--._\n              : ^  ^ :\n              '.'--'.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n              4 Lives";
            string one_wrong = "\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n \\                        /       /\n   \\                     /      /\n     \\                  /     /\n       \\               /    /\n         \\            /   /\n           \\         /  /\n             \\      / /\n               \\   //\n               _.--._\n              : o  o :\n              ' '--' '\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n              3 Lives";
            string two_wrong = "\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n \\                                /\n   \\                            /\n     \\                        /\n       \\                    /\n         \\                /\n           \\            /\n             \\        /\n               \\    /\n               _.--._\n              : o  o :\n              '.----.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n              2 Lives";
            string three_wrong = "\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n                                  /\n                                /\n                              /\n                            /\n                          /\n                        /\n                      /\n                    /\n               _.--._\n              : O__o :\n              '.(__).'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n               1 Life";
            string deceased_jumper = "\n\n               _.--._\n              : X  X :\n              '.----.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n            Game Over...";
            string jumper_win = "\n\n\n               _.--._\n              : ^  ^ :\n              '.'--'.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n            You got it!!";
        }

        public int lives()
        {
            return total_lives;
        }

        public player()
        {
            correct = true;
        }

        private void proper_model()
        {
            if (correct == false)
            {
                total_lives -= 1;
            }
        }

    }
}