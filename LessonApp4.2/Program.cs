using System;

namespace LessonApp4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Title = "MagicFieldGame";   
            MagicFieldGame.StartGame();
            Console.Read();
        }

       public class MagicFieldGame
        {
            public static void WelcomeMessage()
            {
                Console.WriteLine("Welcome to the MagicFieldGame ");
                Console.WriteLine("Let's get Started! ");
                Console.WriteLine("-----------------------\n\n");
                Console.WriteLine("----------------- ----- Please Enter Your Favorite Fruit name : \t");
            }

            public static void StartGame()
            {
                WelcomeMessage();
                
                Console.WriteLine("I thought of a word, which  you have to guess \n");
                string fruitName = Console.ReadLine();
                char[] sweetFruit = fruitName.ToCharArray();
                GuessWord(sweetFruit);  
            }

            public static void GuessWord(char[] sweetFruit)
            {
                char[] tempArray = new char[sweetFruit.Length];
                for (int index = 0; index < tempArray.Length; index++)
                {
                    tempArray[index] = ' ';
                }
                int counter = 0;

                string enteredWord;
                string guessedWord;

                bool noMathces;

                do
                {
                    enteredWord = enterLetter();
                    guessedWord = new string(sweetFruit);
                    noMathces = true;

                    char symbol = enteredWord[0];
                    for (int index = 0; index < sweetFruit.Length; index++)
                    {
                        if (sweetFruit[index].Equals(symbol)  )
                        {
                            tempArray[index] = sweetFruit[index];
                            counter++;
                            noMathces = false; 
                        }
                    }

                    if (noMathces)
                    {
                        Console.WriteLine("There is no such letter...\n");
                    }
                    if (guessedWord.Equals(enteredWord))
                    {
                        Console.WriteLine("Congratulation, You Won and guessed the word - \"{0}\"", enteredWord);
                        return;
                    }

                    if (counter == sweetFruit.Length)
                    {
                        Console.WriteLine("Congratulation, You have guessed the word - \"{0}\". YOU WON!", guessedWord);
                        return;
                    }
               
                    Console.WriteLine();

                } while (counter < sweetFruit.Length);
            }

            static string enterLetter()
            {
                Console.WriteLine("Please guess the Word, or Enter The One English letter : \n");
                return Console.ReadLine();
            }
        }
    }
}
