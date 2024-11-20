using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_game_Multiplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Declarations

            // --- Initializer Variables ---

            // Input to start game or instructions
            int StartGameRead = 0;
            // Bool for do loop if they don't input 1 or 2
            bool StartGameDoLoop = false;

            // --- Game Start Variables ---

            // Inputted word to guess
            string inputtedWord = "";
            // hidden word to show users in stars(*)
            string hiddenWord = "";
           
            StringBuilder wordStart = new StringBuilder(hiddenWord);
            
            //Round number
            int round = 1;
            
            // Random variable for guesses
            Random random = new Random();
            
            // guesses
            int guesses = 0;
            // text to show guesses
            int guessesLeft = 0;
            
            // InputCharacter / Guess
            string inputtedGuess = "";
            
            // picture of hanged man
            string Picture = "";
            
            // text to show if they got it correct or not
            string textYesNo = "";
            
            // array of guessed characters
            string[] charactersGuessed = new string[guesses];

            // variable to compare against array to see if duplicates exist
            string letterfromArray = "";

            // counter for correct/ incorrect text
            int textguessCounter = 0;


            Initializer();
            void Initializer()
            {
                Console.WriteLine("--------------------- Hangman Multiplayer ---------------------");
                Console.Write("\n\n1: Start Game  " +
                                  "\n2: Instructions" +
                                  "\n\nWhat would you like to do: ");

                StartGameRead = int.Parse(Console.ReadLine());

                if (StartGameRead == 1)
                {
                    GameStart();
                }
                else if (StartGameRead == 2)
                {
                    Instructions();
                }
                else
                {
                    StartGameDoLoop = true;
                    do
                    {
                        Console.Write("\n\nThat option doesn't exist, please try again: ");
                        StartGameRead = int.Parse(Console.ReadLine());

                        if (StartGameRead == 1)
                        {
                            StartGameDoLoop = false;
                            GameStart();

                        }
                        else if (StartGameRead == 2)
                        {
                            StartGameDoLoop = false;
                            Instructions();
                        }
                        else
                        {
                            StartGameDoLoop = true;
                        }
                    } while (StartGameDoLoop);
                }

            }
            void Instructions()
            {
                Console.Clear();
                Console.WriteLine("--------------------- Instructions ---------------------");
                Console.Write("\n\n1: When the game starts, you will give a word." +
                              "\n2: Another player will be given a random amount of guesses, to guess your word." +
                              "\n3: if they fail then you win, if they win then you fail and they will give a word for you to guess.\n\n");
                GameStart();
            }
            void GameStart()
            {
                Console.WriteLine("\n\n--------------------- Game Start ---------------------");
                Console.Write("\n\nPlease enter your word: ");
                inputtedWord = Console.ReadLine();
                char[] wordGuessed = inputtedWord.ToCharArray();

                // This adds * stars to a string that is the same size as the inputted word
                for (int WordSize = 0; WordSize < inputtedWord.Length; WordSize++)
                {
                    hiddenWord = hiddenWord.Insert(0, "*");
                    
                }
                // variable that replaces * stars with inputted guess 
                wordStart = new StringBuilder(hiddenWord);
                Console.Clear();
                // Determines how many guesses hthe user gets
                guesses = random.Next(inputtedWord.Length + 1, inputtedWord.Length + 6);
                guessesLeft = guesses;
                // sets array size
                charactersGuessed = new string[guesses];
                // shows the user guessed characters
                string inputtedArrayText = "";

                for (int i = 0; i < guesses; i++)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------- Round {0} ---------------------", round);
                    Console.Write("{0}" +
                                  "{1}" +
                                  "\n\nWord: {2}" +
                                  "\nGuesses left: {3}" +
                                  "\nCharacters Guessed: {4}" +
                                  "\n\nEnter a character to start guessing: ", Picture, textYesNo, wordStart, guessesLeft,inputtedArrayText);
                    inputtedGuess = Console.ReadLine();
                    textguessCounter = 0;

                    for (int iOne = 0; iOne < charactersGuessed.Length; iOne++)
                    {
                        if (charactersGuessed.Length == 1)
                        {
                            letterfromArray = "";
                        }
                        else
                        {
                            letterfromArray = charactersGuessed[iOne];
                        }

                        // if character alread exists in array
                        if (letterfromArray == inputtedGuess)
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
                                for (int iTwo = 0; iTwo < charactersGuessed.Length; iTwo++)
                                {
                                    // if inputted word = array character 
                                    if (readlineword == charactersGuessed[iTwo])
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
                                    if (arrayCounter == charactersGuessed.Length)
                                    {
                                        repeatedChar = false;
                                        // sets inputted character to array 
                                        inputtedGuess = readlineword;
                                    }
                                }
                            } while (repeatedChar);
                        }
                    }
                    // adds input to array
                    charactersGuessed[i] = inputtedGuess;
                    

                    for (int iThree = 0; iThree < wordGuessed.Length; iThree++)
                    {
                        if (inputtedGuess == wordGuessed[iThree].ToString())
                        {
                            wordStart[iThree] = char.Parse(inputtedGuess);
                            textYesNo = "\n\n-- Correct --";
                            
                            round += 1;
                        }
                        else
                        {
                            textguessCounter++;
                        }

                        if(wordStart.ToString() == inputtedWord)
                        {
                            i = guessesLeft;
                            Win(guessesLeft);
                        }

                        if(textguessCounter == wordGuessed.Length)
                        {
                            textYesNo = "\nzn-- Incorrect --";
                            guessesLeft -= 1;
                            round += 1;
                        }
                    }
                    Console.WriteLine();

                    if (guessesLeft == 8)
                    {
                        Picture = "\n\n" +
                            "         \n" +
                            "        \n" +
                            "|       \n" +
                            "|       \n" +
                            "--       ";
                    }
                    else if (guessesLeft == 7)
                    {
                        Picture = "\n\n" +
                            "|-----| \n" +
                            "|       \n" +
                            "|       \n" +
                            "|       \n" +
                            "--       ";
                    }
                    else if (guessesLeft == 6)
                    {
                        Picture = "\n\n" +
                            "|-----| \n" +
                            "|     o  \n" +
                            "|       \n" +
                            "|       \n" +
                            "--       ";
                    }
                    else if (guessesLeft == 5)
                    {
                        Picture = "\n\n" +
                            "|-----|    \n" +
                            "|     o    \n" +
                            "|     |    \n" +
                            "|          \n" +
                            "--           ";
                    }
                    else if (guessesLeft == 4)
                    {
                        Picture = "\n\n" +
                            "|-----|     \n" +
                            "|     o    \n" +
                            "|    /|    \n" +
                            "|          \n" +
                            "--           ";
                    }
                    else if (guessesLeft == 3)
                    {
                        Picture = "\n\n" +
                            "|-----|    \n" +
                            "|     o    \n" +
                            "|    /|\\  \n" +
                            "|          \n" +
                            "--           ";
                    }
                    else if (guessesLeft == 2)
                    {
                        Picture = "\n\n" +
                            "|-----|    \n" +
                            "|     o    \n" +
                            "|    /|\\  \n" +
                            "|      \\  \n" +
                            "--           ";
                    }
                    else if (guessesLeft == 1)
                    {
                        Picture = "\n\n" +
                            "|-----| \n" +
                            "|     o  \n" +
                            "|    /|\\  \n" +
                            "|    / \\  \n" +
                            "--       ";
                    }
                    else if (guessesLeft == 0)
                    {
                        i = guessesLeft;
                        Lose(Picture);

                    }
                }
            }
            void Win(int _guessesLeft)
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
