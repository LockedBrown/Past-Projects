using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman_game
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            // data declaration
            int WordCount = 0, StartOption = 0;
            bool GameStartLoopEnd = false, WordCountLoopEnd = false;
            string WordPicked = "";
            Random Random = new Random();
            int RandomNumber = 0;

            // Start Game
            GameStart();

            // Starts the game 
            void GameStart()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Hang Man\n");
                Console.WriteLine("1: Start");
                Console.WriteLine("2: Instructions\n");


                // Loop for correct option
                do
                {
                    Console.Write("What would you like to do: ");
                    StartOption = int.Parse(Console.ReadLine());

                    if (StartOption == 1)
                    {
                        GameStartLoopEnd = true;
                        HangMan();

                    }
                    else if (StartOption == 2)
                    {
                        GameStartLoopEnd = true;
                        Console.WriteLine("\n------------------------------------------------\n");
                        Console.WriteLine("Instructions");
                        Console.WriteLine("\n " +
                            "1: Give the program a word size " +
                            "\n 2: Try guess the programs word " +
                            "\n 3: Guess wrong to many times and you will hang the man\n\n");
                        HangMan();


                    }
                    else
                    {
                        GameStartLoopEnd = false;
                        Console.WriteLine("\n** Please select a correct option **\n");
                    }

                } while (GameStartLoopEnd == false);

              

            }
            // Starts the game
            void HangMan()
            {

                Console.WriteLine("\n------------------------------------------------\n");
                Console.WriteLine("Start\n");

                // Loop - Word Count between 3 - 8 
                do
                {
                    Console.Write("\nEnter a word size number between 3-8: ");
                    WordCount = int.Parse(Console.ReadLine());

                    // do loop end
                    if (WordCount >= 3 && WordCount <= 8)
                    {
                        WordCountLoopEnd = true;
                        Words(WordCount);
                        
                    }
                    else
                    {
                        WordCountLoopEnd = false;
                        Console.WriteLine("\n ** Number has to been between 3 - 8 ** \n");
                    }
                } while (WordCountLoopEnd == false);
            }
            // List of all the words, this generates the random word when given the word character amount
            void Words(int _WordCount)
            {
                // Word Array Multidemensional
                string[,] word =
                {
                    { "car", "bar", "ear", "jug", "mug", "jaw", "paw", "jam", "zap","joy", "bed" },
                    { "head", "dead", "claw", "door", "bore", "yawn", "dawn", "pawn", "face", "bass", "base"},
                    { "crack","knack","brick","fuzzy","pizza","jumpy","jumbo","mongo","bongo","quack","juked" },
                    { "jazzed","zizzle","bizzle","muzzle","puzzle","buzzer","munchy","punchy","razzed","quartz","snorty" },
                    { "lizard","jukebox","jimjams","buzzing","puzzled","nuzzler","jamming","jumbled","mumbled","lockbox","junking" },
                    { "maximize","minimize","grizzles","blizzard","dazzlers","jiujitsu","lockjaws","muckluck","jackdaws","equalize","bejumble" }
                };

                // Picks a random word from each word size
                switch (_WordCount)
                {
                    case 3:
                        RandomNumber = Random.Next(0, 11);
                        WordPicked = word[0, RandomNumber];

                        break;
                    case 4:
                        RandomNumber = Random.Next(0, 11);
                        WordPicked = word[1, RandomNumber];
                        break;
                    case 5:
                        RandomNumber = Random.Next(0, 11);
                        WordPicked = word[2, RandomNumber];
                        break;
                    case 6:
                        RandomNumber = Random.Next(0, 11);
                        WordPicked = word[3, RandomNumber];
                        break;
                    case 7:
                        RandomNumber = Random.Next(0, 11);
                        WordPicked = word[4, RandomNumber];
                        break;
                    case 8:
                        RandomNumber = Random.Next(0, 11);
                        WordPicked = word[5, RandomNumber];
                        break;

                }

                // Calls the guessing method
                Guessing(WordPicked, _WordCount);                                                              
            }

            // This is the loop to gather all of the guessed letter
            void Guessing(string _Wordpicked, int _wordCount)
            {

                // Data declaration
                // Reads the guessed character
                string readlineCharacter = "";
                string wordChoosen = _Wordpicked;
                string wordHidden = "";
                char[] wordToChar = _Wordpicked.ToCharArray();


                for(int WordAmount = 0; WordAmount < _wordCount; WordAmount++)
                {
                    wordHidden = wordHidden.Insert(0, "*");     
                }
                StringBuilder wordStar = new StringBuilder(wordHidden);


                // Guesses available
                int guesses = _wordCount + 5;

                // shows the value in a writeline
                int guessed = guesses;
                // shows the text in a writeline
                string text = "guesses";

                // this contains the value of the guessed characters to see if theres duplicates
                string wordfromArray = "";

                // guessed array to show user
                string inputtedArrayText = "";
                string HangManPic = "";

                // variable to say if they guessed right or not
                string textGuess = "";
                int textguessCounter = 0;

                // array of guessed characters
                string[] charactersUsed = new string[guesses];

                // Loops while the user has guesses
                for (int i = 0; i < guesses; i++)
                {
                    // Clears console
                    Console.Clear();
                    Console.WriteLine("\n ** I have choosen my word **");
                    Console.Write("{0}", textGuess);
                    Console.Write("{0}", HangManPic);
                    Console.WriteLine("\nyou have {0} {1} left, {2}\n", guessed, text, wordStar);
                    Console.WriteLine("Guessed Characters: {0}", inputtedArrayText);
                    Console.Write("Enter a character to guess: ");

                    textguessCounter = 0;
                    // gets input
                    readlineCharacter = Console.ReadLine();



                    // goes through the array to add characters
                    for (int index = 0; index < charactersUsed.Length; index++)
                    {
                        // skips the first index
                        if (charactersUsed.Length == 1)
                        {
                        wordfromArray = "";
                        }
                        else
                        {
                        wordfromArray = charactersUsed[index];
                            
                        }
                        // if character has been used                            
                        if (wordfromArray == readlineCharacter)
                        {
                                
                                string readlineword = "";

                                // do loop - bool
                                bool repeatedChar = true;

                                // bool to get input
                                bool looprepeat = false;

                                // variable to count array size, if arrayCounter = array size then loop doesn't repeat
                                int arrayCounter = 0;
                                
                                // gets input
                                Console.Write("\nPlease type another character: ");
                                readlineword = Console.ReadLine();
                                Console.WriteLine("");

                            // do loop makes sure input character isn't the same
                            do
                            {
                                // sets arrayCounter to 0 on repeat
                                arrayCounter = 0;

                                // loop to run through array index
                                for (int iThree = 0; iThree < charactersUsed.Length; iThree++)
                                {
                                    // if inputted word = array character 
                                    if (readlineword == charactersUsed[iThree])
                                    {
                                        looprepeat = true;
                                    }
                                    else
                                    {
                                        looprepeat = false;                                     
                                        arrayCounter++;
                                    }
                                    // repeats message and gets input
                                    if (looprepeat == true)
                                    {
                                        Console.Write("\nPlease type another character: ");
                                        readlineword = Console.ReadLine();
                                        Console.WriteLine("");
                                    }

                                    // if arrayCounter = array size then loop over
                                    if (arrayCounter == charactersUsed.Length)
                                    {
                                        repeatedChar = false;
                                        // sets inputted character to array 
                                        readlineCharacter = readlineword;
                                    }
                                }
                            } while (repeatedChar);

                        }

                    }
                    // adds input to array
                    charactersUsed[i] = readlineCharacter;
                    inputtedArrayText += readlineCharacter + ", ";

                    // changes the hidden word to show the characters guessed
                    for (int guessedCorrectly = 0; guessedCorrectly < wordToChar.Length; guessedCorrectly++)
                    {
                        if (readlineCharacter == wordToChar[guessedCorrectly].ToString())
                        {
                            wordStar[guessedCorrectly] = Char.Parse(readlineCharacter);
                            guessed += 1;
                            i -= 1;
                            textGuess = "\n--------------------------------------------- Correct Guess! ---------------------------------------------\n";
                            
                        }
                        else
                        {
                            textguessCounter++;
                        }

                        if (wordStar.ToString() == wordChoosen)
                        {
                            i = guessed;
                            Win(guessed);
                        }

                        if (textguessCounter == wordToChar.Length)
                        {
                            textGuess = "\n-------------------------------------------- Incorrect Guess! --------------------------------------------\n";
                        }
                        
                    }



                    guessed -= 1;
                    if (guessed == 8)
                    {
                        HangManPic = "\n\n" +
                            "         \n" +
                            "        \n" +
                            "|       \n" +
                            "|       \n" +
                            "--       ";
                    }
                    else if (guessed == 7)
                    {
                        HangManPic = "\n\n" +
                            "|-----| \n" +
                            "|       \n" +
                            "|       \n" +
                            "|       \n" +
                            "--       ";
                    }
                    else if (guessed == 6)
                    {
                        HangManPic = "\n\n" +
                            "|-----| \n" +
                            "|     o  \n" +
                            "|       \n" +
                            "|       \n" +
                            "--       ";
                    }
                    else if (guessed == 5)
                    {
                        HangManPic = "\n\n" +
                            "|-----|    \n" +
                            "|     o    \n" +
                            "|     |    \n" +
                            "|          \n" +
                            "--           ";
                    }
                    else if (guessed == 4)
                    {
                        HangManPic = "\n\n" +
                            "|-----|     \n" +
                            "|     o    \n" +
                            "|    /|    \n" +
                            "|          \n" +
                            "--           ";
                    }
                    else if (guessed == 3)
                    {
                        HangManPic = "\n\n" +
                            "|-----|    \n" +
                            "|     o    \n" +
                            "|    /|\\  \n" +
                            "|          \n" +
                            "--           ";
                    }
                    else if (guessed == 2)
                    {
                        HangManPic = "\n\n" +
                            "|-----|    \n" +
                            "|     o    \n" +
                            "|    /|\\  \n" +
                            "|      \\  \n" +
                            "--           ";
                    }
                    else if (guessed == 1)
                    {
                        HangManPic = "\n\n" +
                            "|-----| \n" +
                            "|     o  \n" +
                            "|    /|\\  \n" +
                            "|    / \\  \n" +
                            "--       ";
                    }
                    else if (guessed == 0)
                    {
                        i = guessed;
                        Lose(HangManPic);
                        
                    }



                }
            }


            void Win(int guesses)
            {
                string guesstext = "";
                if (guesses == 1)
                {
                    guesstext = "guess";
                }
                else
                {
                    guesstext = "guesses";
                }


                Console.Clear();
                Console.WriteLine("You have won with {0} {1} left", guesses, guesstext);
                Console.ReadLine();
            }

            void Lose(string HangmanPic)
            {
                Console.Clear();
                Console.WriteLine(HangmanPic);
                Console.ReadLine();

            }

        }


    }
}
