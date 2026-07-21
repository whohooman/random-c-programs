using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//My first text game:Castle of doom 
//Karabo Adoons 21/07/2026
namespace textGame
{
    internal class Program
    {
        // Global variables 
        static int press, health = 100, energy;
        static string sword = "sword", name, answer;
        static void Main()
        {
            //For the big text i searched ascii text generator and pressed ASCII Art
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ____          _   _         ___   __   ____   ___   ___  __  __ \r\n / ___|__ _ ___| |_| | ___   / _ \\ / _| |  _ \\ / _ \\ / _ \\|  \\/  |\r\n| |   / _` / __| __| |/ _ \\ | | | | |_  | | | | | | | | | | |\\/| |\r\n| |__| (_| \\__ \\ |_| |  __/ | |_| |  _| | |_| | |_| | |_| | |  | |\r\n \\____\\__,_|___/\\__|_|\\___|  \\___/|_|   |____/ \\___/ \\___/|_|  |_|");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Enter player name:");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to access storyline and press 2 to cancel storyline");
            press = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            //Switch statement
            switch(press)
            {
                case 1:
                    StoryLine();
                    break;
                case 2:
                    Mission();
                    break;
                default:
                    Console.WriteLine("You pressed the wrong number, press any button to start again");
                    Console.ReadKey();
                    Console.Clear();    
                    Main();
                    break;
            }
        }
        static void StoryLine()
        {
            //Story line 
            Console.Write("Long time ago, there was a warrior >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Write("He was a killer in his time, slaying thousands of people and conquering many lands >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Write("One day...>>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Write("He came across an easy village to conquer >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Write("The village was prospering even though vast lands surrounding it were largely barren >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The Warrior was salivated by the large vegetation in the village >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("So he and his 5000 men rode fast as they could with their horses >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Expecting some sort of a fight they pulled up their swords >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("But as they went closer to the village no one was was there to resist their forces >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Until... >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("A DARK CLOUD surrounded the 5000 soldiers and in a span of seconds >>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            //Change color for text dramatization 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DEAD ");
            //Reset color
            Console.ResetColor();
            Console.Write("All the troops but one man...");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("THE WARRIOR >>>> Press to continue");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Mission();
        }
        static void Mission()
        {
            //For the Castle i searched ASCII Art Generator and pressed ASCII Art
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ____          _   _         ___   __   ____   ___   ___  __  __ \r\n / ___|__ _ ___| |_| | ___   / _ \\ / _| |  _ \\ / _ \\ / _ \\|  \\/  |\r\n| |   / _` / __| __| |/ _ \\ | | | | |_  | | | | | | | | | | |\\/| |\r\n| |__| (_| \\__ \\ |_| |  __/ | |_| |  _| | |_| | |_| | |_| | |  | |\r\n \\____\\__,_|___/\\__|_|\\___|  \\___/|_|   |____/ \\___/ \\___/|_|  |_|");
            Console.WriteLine();
            //Change color 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("SCROLL DOWN FOR FULL VIEW OF THE CASTLE AND PRESS TO CONTINUE");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::::::::::::::::::-**++=:::::::::::::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::::::::::::::::::---::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::::::::::::::::::**:::::::::::::::::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::::::::::......:#%%#:......:::::::::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::::...........:#%%%%#:...........:::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::..............-#%%%%%%#-..............:::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::...............-%%%%%%%%%%-...............:::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::.................-%%%%%%%%%%%%-................:::::::::::::::::::::::::::\r\n::::::::::::::::::::::::....................*%%%%%%%%%%*....................::::::::::::::::::::::::\r\n::::::::::::::::::::::::....................*%#%%##%%*%*.....................:::::::::::::::::::::::\r\n:::::::::::::::::::::.......................**.*%::%+.**.......................:::::::::::::::::::::\r\n::::::::::::::::::::............:-::........*%%%%%%%%%%*...........:-:::........::::::::::::::::::::\r\n:::::::::::::::::::.............=+==-:......-#%%%%%%%%#-...........-++=--:.......:::::::::::::::::::\r\n::::::::::::::::::..............-............+%%%%%%%%+............-..............::::::::::::::::::\r\n:::::::::::::::::...............-...........:%%%%%%%%%%:...........-...............:::::::::::::::::\r\n::::::::::::::::...............*%=..........=%%%%%%%%%%=..........=%*...............::::::::::::::::\r\n::::::::::::::::.............:*%%%=.........#%%%%%%%%%%#.........=%%%*:.............::::::::::::::::\r\n:::::::::::::::.............:*%%%%%=.......-%%%%%%%%%%%%-.......=%%%%%#:.............:::::::::::::::\r\n:::::::::::::::............:#%%%%%%%*.:-:..+##%%####%%##+..:-:.*%%%%%%%#:............:::::::::::::::\r\n:::::::::::::::...........-%%%%%%%%%%##%+..*%%%%#%%#%%%%*..+%##%%%%%%%%%%-............::::::::::::::\r\n::::::::::::::...........-#%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%#-...........::::::::::::::\r\n:::::::::::::::...........=%%%%%%%%%%%%%%*#%%%%%%##%%%%%%#*%%%%%%%%%%%%%%=............::::::::::::::\r\n::::::::::::::............=%+*%*=#%+*%%%%##%%%%%%##%%%%%%##%%%%*+%#=#%*+%=............::::::::::::::\r\n::::::::::::::............=%-+%+-*#=+%%%%%%%%%%%%%%%%%%%%%%%%%%+=#*-+%+-%=............::::::::::::::\r\n::::::::::::::............=%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%=............::::::::::::::\r\n:::::::::::::::.:::...::...*%%%%%%%%%#%%*###%#*#*%%*#*#%###*%%#%%%%%%%%%*...::...:::.:::::::::::::::\r\n:::::=%%=::#%*:.=%%:.-#%+..-%%%%%%%%%#%%#%%*##%%####%%##*%%#%%#%%%%%%%%%-..+%#-.:%%=.:*%#::=%%=:::::\r\n:::::=%%#**%%%**#%%**#%%+..-%%%%%%%%%#%%#%%%%%%%%%%%%%%%%%%#%%#%%%%%%%%%-..+%%#**%%#**%%%**#%%=:::::\r\n:::::=%%%%%%%%%%%%%%%%%%+..-%%%%%%%%%#%%#%%%%%%%%%%%%%%%%%%#%%#%%%%%%%%%-..+%%%%%%%%%%%%%%%%%%=:::::\r\n:::::-*%%%%%%%%%%%%%%%%#-..-%%%%%%%%%#%%%##################%%%#%%%%%%%%%-..-#%%%%%%%%%%%%%%%%*-:::::\r\n::::::=%%%%%%%%%%%%%%%%=.-*%%%%%%%%%%#%%%#%%%%%%%%%%%%%%%%#%%%#%%%%%%%%%%*-.=%%%%%%%%%%%%%%%%=::::::\r\n::::::=%%%%%%%%%%%%%%%#+=#%#**#%%***%##**#%%%%%%%%%%%%%%%%#**##%***%%#**#%#=+#%%%%%%%%%%%%%%%=::::::\r\n::::::=%%%%%%%+=#%%%%%%%%#%*%%%%%#%#%##%%%%%%%%%%%%%%%%%%%%%%##%#%#%%#%%*%#%%%%%%%%#=+%%%%%%%=::::::\r\n::::::=%%%%%%#-:+%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%%%+:-#%%%%%%=::::::\r\n::::::=%%%%%%%%#%%%%%%%%%%=#%*+%%=#%=*%%#%%%%%%%%%%%%%%%%%%#%%+=%#=%%+*%#=%%%%%%%%%%#%%%%%%%%=::::::\r\n::::::=%%%++%%%%%%*=#%#%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%#%#=*%%%%%%++%%%=::::::\r\n:::::=%%%#-:#%%%%#-:=%%#%%%%%%%%%%%%%%%#%%%%%%%#*++*#%%%%%%%#%%%%%%%%%%%%%%%#%%=:-#%%%%#:-#%%#=:::::\r\n:::::=%%%%##%%%%%%#*#%%#%%%%%%%%%%%%%%%#%%%%%%###**###%%%%%%#%%%%%%%%%%%%%%%#%%#*#%%%%%%##%%%%=:::::\r\n:::::=%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%#%%%%%####**####%%%%%#%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%=:::::\r\n:::::=%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%%%%%#********#%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%=:::::\r\n:::::=%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%#***++***#%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%=:::::\r\n:::::=%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%####**####%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%=:::::\r\n:::::=%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%%%#%%%%%%####**####%%%%%%#%%%%%%%%%%%%%%#%%%%%%%%%%%%%%%%%=:::::\r\n:::::=#################*##############*######*+++==+++*######*##############*#################=:::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n====================================================================================================\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@%%*####*##**#+###**%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%@%%@%#%@@%@@@%%@%####%%%#%@@@\r\n@@@#@#%*%##%%###%#%#%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%@#%%%%%%%%@%@%%%%%%%@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                       @@                           \r\n                  @@@@@@@@@                         \r\n                 @@@@@@@@@@@                        \r\n                @ @@@@@ @@@@                        \r\n                  @@     @@                         \r\n                  @@  @@@@@@@@@                     \r\n                  @@@ @@@@@@@@@@                    \r\n                    @@@ @@ @@@@@                    \r\n                    @@@@@@@@@@@@                    \r\n                    @    @@    @                    \r\n                    @@@@ @@ @@@@                    \r\n                    @@@@  @ @@@@                    \r\n                @@  @ @@ @@ @@@@  @@                \r\n           @@@@@@@@@  @@    @@  @@@@@@@@@           \r\n                  @@@       @  @@@                  \r\n                              @                     \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    ");
            Console.ResetColor();
            Console.WriteLine("Warrior: WHO IS THIS??(SHOOK) YOU KILLED MY TROOPS IN AN INSTANT. YOU DARE DEFY THE MIGHTY {0}!!", name);
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("              .   .         .   . . ...   ..     \r\n  .    .  . ..  .     ..   .     .               \r\n       .  . .     ..  .. .  .  ..   .  .     ..  \r\n      . .        .                      .    . ..\r\n .   .  . .     ....     ...:+#..             .. \r\n ...       .  .         .-*%%%%%#.         .     \r\n    .           .   ..=***#%%%%%%%. . .       .  \r\n         . =%#=...:*%%#%%%%%%%%%%%#.      .   .. \r\n  .  .    .*%%%%%*:.=%%%%%%%%%%%%%%=    .      ..\r\n ..      . :%%%%%%%%%+:-#%%%%%%%:%%%+  . . .  .  \r\n..          :%%%%%%%%%%%#:-%%%%%..*%%.         . \r\n .        .  .*%-#%#+.#%%%%#-#%%#. #: ..    .    \r\n.        .     .*%+...#%%%%%%%#%#.  .  .  ..     \r\n     ..  ..    -+%%*:%%%%%%%%%%%%%=.        .    \r\n.. .            .-+%%%%%%%%%%%%%%%%%#-           \r\n         .    .:%%%%%%%%%%%%%%%%%%%%%=    .  .   \r\n .          ..-%%%%%%%%%%%%%%%%%%=::.   .  .   . \r\n .            .*%%%%%%%%%%%%%%-.=-.      . .    .\r\n         . . ..*%%%%%%%%%%%%#:=:          .      \r\n  .        .   .%%%*%%%%%%%%%*.  .     .  ..    .\r\n.               .+%#.=%%=%%%*+*+:      ..   ...  \r\n      .          ...-=.....-*+.      .  .        \r\n.    .     .       .  .             . .          \r\n     .    .           .  .  . .  .     ..  .     \r\n                  .   .        .     .  .   .   .\r\n.    .     .        ..  .                        ");
            Console.WriteLine("Wizard: Its me you bitch ass nigga, I saw 4 years ago you'll come here. why do you think a small village like this would have this much vegetation? You have strength but not smart, you're gonna die");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear() ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                       @@                           \r\n                  @@@@@@@@@                         \r\n                 @@@@@@@@@@@                        \r\n                @ @@@@@ @@@@                        \r\n                  @@     @@                         \r\n                  @@  @@@@@@@@@                     \r\n                  @@@ @@@@@@@@@@                    \r\n                    @@@ @@ @@@@@                    \r\n                    @@@@@@@@@@@@                    \r\n                    @    @@    @                    \r\n                    @@@@ @@ @@@@                    \r\n                    @@@@  @ @@@@                    \r\n                @@  @ @@ @@ @@@@  @@                \r\n           @@@@@@@@@  @@    @@  @@@@@@@@@           \r\n                  @@@       @  @@@                  \r\n                              @                     \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    ");
            Console.ResetColor();
            Console.WriteLine("Warrior: How did you kill my men? What is this? I must be dreaming.....");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("              .   .         .   . . ...   ..     \r\n  .    .  . ..  .     ..   .     .               \r\n       .  . .     ..  .. .  .  ..   .  .     ..  \r\n      . .        .                      .    . ..\r\n .   .  . .     ....     ...:+#..             .. \r\n ...       .  .         .-*%%%%%#.         .     \r\n    .           .   ..=***#%%%%%%%. . .       .  \r\n         . =%#=...:*%%#%%%%%%%%%%%#.      .   .. \r\n  .  .    .*%%%%%*:.=%%%%%%%%%%%%%%=    .      ..\r\n ..      . :%%%%%%%%%+:-#%%%%%%%:%%%+  . . .  .  \r\n..          :%%%%%%%%%%%#:-%%%%%..*%%.         . \r\n .        .  .*%-#%#+.#%%%%#-#%%#. #: ..    .    \r\n.        .     .*%+...#%%%%%%%#%#.  .  .  ..     \r\n     ..  ..    -+%%*:%%%%%%%%%%%%%=.        .    \r\n.. .            .-+%%%%%%%%%%%%%%%%%#-           \r\n         .    .:%%%%%%%%%%%%%%%%%%%%%=    .  .   \r\n .          ..-%%%%%%%%%%%%%%%%%%=::.   .  .   . \r\n .            .*%%%%%%%%%%%%%%-.=-.      . .    .\r\n         . . ..*%%%%%%%%%%%%#:=:          .      \r\n  .        .   .%%%*%%%%%%%%%*.  .     .  ..    .\r\n.               .+%#.=%%=%%%*+*+:      ..   ...  \r\n      .          ...-=.....-*+.      .  .        \r\n.    .     .       .  .             . .          \r\n     .    .           .  .  . .  .     ..  .     \r\n                  .   .        .     .  .   .   .\r\n.    .     .        ..  .                        ");
            Console.WriteLine("Wizard: A warrior well travelled like yourself doesnt know magic?");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                       @@                           \r\n                  @@@@@@@@@                         \r\n                 @@@@@@@@@@@                        \r\n                @ @@@@@ @@@@                        \r\n                  @@     @@                         \r\n                  @@  @@@@@@@@@                     \r\n                  @@@ @@@@@@@@@@                    \r\n                    @@@ @@ @@@@@                    \r\n                    @@@@@@@@@@@@                    \r\n                    @    @@    @                    \r\n                    @@@@ @@ @@@@                    \r\n                    @@@@  @ @@@@                    \r\n                @@  @ @@ @@ @@@@  @@                \r\n           @@@@@@@@@  @@    @@  @@@@@@@@@           \r\n                  @@@       @  @@@                  \r\n                              @                     \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    \r\n                                                    ");
            Console.ResetColor();
            Console.WriteLine("Warrior: M.M. Magic??");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("              .   .         .   . . ...   ..     \r\n  .    .  . ..  .     ..   .     .               \r\n       .  . .     ..  .. .  .  ..   .  .     ..  \r\n      . .        .                      .    . ..\r\n .   .  . .     ....     ...:+#..             .. \r\n ...       .  .         .-*%%%%%#.         .     \r\n    .           .   ..=***#%%%%%%%. . .       .  \r\n         . =%#=...:*%%#%%%%%%%%%%%#.      .   .. \r\n  .  .    .*%%%%%*:.=%%%%%%%%%%%%%%=    .      ..\r\n ..      . :%%%%%%%%%+:-#%%%%%%%:%%%+  . . .  .  \r\n..          :%%%%%%%%%%%#:-%%%%%..*%%.         . \r\n .        .  .*%-#%#+.#%%%%#-#%%#. #: ..    .    \r\n.        .     .*%+...#%%%%%%%#%#.  .  .  ..     \r\n     ..  ..    -+%%*:%%%%%%%%%%%%%=.        .    \r\n.. .            .-+%%%%%%%%%%%%%%%%%#-           \r\n         .    .:%%%%%%%%%%%%%%%%%%%%%=    .  .   \r\n .          ..-%%%%%%%%%%%%%%%%%%=::.   .  .   . \r\n .            .*%%%%%%%%%%%%%%-.=-.      . .    .\r\n         . . ..*%%%%%%%%%%%%#:=:          .      \r\n  .        .   .%%%*%%%%%%%%%*.  .     .  ..    .\r\n.               .+%#.=%%=%%%*+*+:      ..   ...  \r\n      .          ...-=.....-*+.      .  .        \r\n.    .     .       .  .             . .          \r\n     .    .           .  .  . .  .     ..  .     \r\n                  .   .        .     .  .   .   .\r\n.    .     .        ..  .                        ");
            Console.WriteLine("SAY LESS I'LL SHOW YOU");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("              .   .         .   . . ...   ..     \r\n  .    .  . ..  .     ..   .     .               \r\n       .  . .     ..  .. .  .  ..   .  .     ..  \r\n      . .        .                      .    . ..\r\n .   .  . .     ....     ...:+#..             .. \r\n ...       .  .         .-*%%%%%#.         .     \r\n    .           .   ..=***#%%%%%%%. . .       .  \r\n         . =%#=...:*%%#%%%%%%%%%%%#.      .   .. \r\n  .  .    .*%%%%%*:.=%%%%%%%%%%%%%%=    .      ..\r\n ..      . :%%%%%%%%%+:-#%%%%%%%:%%%+  . . .  .  \r\n..          :%%%%%%%%%%%#:-%%%%%..*%%.         . \r\n .        .  .*%-#%#+.#%%%%#-#%%#. #: ..    .    \r\n.        .     .*%+...#%%%%%%%#%#.  .  .  ..     \r\n     ..  ..    -+%%*:%%%%%%%%%%%%%=.        .    \r\n.. .            .-+%%%%%%%%%%%%%%%%%#-           \r\n         .    .:%%%%%%%%%%%%%%%%%%%%%=    .  .   \r\n .          ..-%%%%%%%%%%%%%%%%%%=::.   .  .   . \r\n .            .*%%%%%%%%%%%%%%-.=-.      . .    .\r\n         . . ..*%%%%%%%%%%%%#:=:          .      \r\n  .        .   .%%%*%%%%%%%%%*.  .     .  ..    .\r\n.               .+%#.=%%=%%%*+*+:      ..   ...  \r\n      .          ...-=.....-*+.      .  .        \r\n.    .     .       .  .             . .          \r\n     .    .           .  .  . .  .     ..  .     \r\n                  .   .        .     .  .   .   .\r\n.    .     .        ..  .                        ");
            Console.WriteLine("ENTER THE CASTLE!!!");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            OutsideDoor();
        }
        static void Ifstatements1()
        {
            //if statements for health
            if(health == 0)
            {
                GameOver();
            }
        }
        static void OutsideDoor()
        {
            //Ask for player name
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU MUST ENTER THE DOOR TO THE CASTLE AND GET OUT ALIVE TO WIN GAME");
            Console.ResetColor();
            Console.WriteLine("Warrior: {0}",name);
            Console.WriteLine("Health:  {0}", health);
            Console.WriteLine("Weapon:  {0}", sword);
            Console.WriteLine(">>>> Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Warrior: {0}", name);
            Console.WriteLine("Health:  {0}", health);
            Console.WriteLine("Weapon:  {0}", sword);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DOOR THE CASTLE: YOU MUST ANSWER SIX QUESTIONS TO ENTER THIS CASTLE, ANSWER IN SMALL LETTERS ONLY");
            Console.WriteLine(">>>>Press to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Warrior: {0}", name);
            Console.WriteLine("Health:  {0}", health);
            Console.WriteLine("Weapon:  {0}", sword);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 + 1?");
            answer = Console.ReadLine();

            //If statement for answer
            if (answer == "2")
            {
                Console.WriteLine("Warrior: {0}", name);
                Console.WriteLine("Health:  {0}", health);
                Console.WriteLine("Weapon:  {0}", sword);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ANSWER IN SMALL LETTERS ONLY");
                Console.WriteLine("DOOR TO THE CASTLE: NOT BAD, GIMME A SURNAME OF THE MAN WHO SCORED A GOAL FOR SOUTH AFRICA IN 2010");
            }
            else if (answer != "2")
            {
                health = 50;
                GameOver();
                Console.WriteLine("Warrior: {0}", name);
                Console.WriteLine("Health:  {0}", health);
                Console.WriteLine("Weapon:  {0}", sword);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ANSWER IN SMALL LETTERS ONLY");
                Console.WriteLine("DOOR TO THE CASTLE: YOU'RE LOSING HEALTH, GIMME A SURNAME OF THE MAN WHO SCORED A GOAL FOR SOUTH AFRICA IN 2010");
            }
           
        } 
        static void GameOver()
        {
            Console.WriteLine("You're dead, press key to start over");
            Console.ReadKey();
            Main();
        }

    }
}
