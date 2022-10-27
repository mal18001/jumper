namespace jumper.Game
{
    public class player
    {
        public static player decide = new player();

        private int total_lives = 4;
        private bool correct;
        public void models()
        {
            List<string> jumpers = new List<string>();
            jumpers.Add("\n\n               _.--._\n              : X  X :\n              '.----.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n            Game Over...");
            jumpers.Add("\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n                                  /\n                                /\n                              /\n                            /\n                          /\n                        /\n                      /\n                    /\n               _.--._\n              : O__o :\n              '.(__).'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n               1 Life");
            jumpers.Add("\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n \\                                /\n   \\                            /\n     \\                        /\n       \\                    /\n         \\                /\n           \\            /\n             \\        /\n               \\    /\n               _.--._\n              : o  o :\n              '.----.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n              2 Lives");
            jumpers.Add("\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n \\                        /       /\n   \\                     /      /\n     \\                  /     /\n       \\               /    /\n         \\            /   /\n           \\         /  /\n             \\      / /\n               \\   //\n               _.--._\n              : o  o :\n              ' '--' '\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n              3 Lives");
            jumpers.Add("\n\n         ___________________\n     ..''                   ''..\n  .''                          ''.\n /__...---''''''''''''''''---...__\\\n \\       \\                /       /\n   \\      \\              /      /\n     \\     \\            /     /\n       \\    \\          /    /\n         \\   \\        /   /\n           \\  \\      /  /\n             \\ \\    / /\n               \\\\  //\n               _.--._\n              : ^  ^ :\n              '.'--'.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n              4 Lives");
            jumpers.Add("\n\n\n               _.--._\n              : ^  ^ :\n              '.'--'.'\n                /||\\\n              /  ||  \\\n            /    ||    \\\n                 /\\\n                /  \\\n               /    \\\n              /      \\\n\n            You got it!!");


            Console.WriteLine(jumpers[total_lives]);
        }

        public int lives()
        {
            return total_lives;
        }

        public player()
        {
            correct = true;
        }

        public void proper_model()
        {
            if (correct == false)
            {
                total_lives -= 1;
            }
        }   

    }
}