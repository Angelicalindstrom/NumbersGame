namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Angelica Lindström, Sundsvall .NET23

            int number = Program.RandomintGenerator();   // Integer that saves the number of the Rendomising Method

            int counter = 1;  // integer that´s used in the counter method, to keep count.
            

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            while (true) // While loop that runs while true.
            {
                Console.Write("Var god ange ett nummer:");
                string inputUser = Console.ReadLine();


                if (int.TryParse(inputUser, out int userNumberGuess)) // if true, save value in inputUser, then runs trough downwards
                {
                
                    counter++;  //keeps count of userGuesses


                    if (userNumberGuess == number)   // if userNumberGuess is same as Random number, WINNER!!! Game ends with break.
                    {
                        Console.WriteLine(" ");
                        Console.Write("Wow Grattis du gissade rätt!! ***,\nNu avslutas programmet, tack för att du deltog! ");
                        Console.WriteLine("Tryck på vilken tangent som helst för att avsluta.");
                        Console.Read();
                        break;
                    }
                    if (userNumberGuess < number) // if userNumberGuess is lower than Random number, user gets message 
                    {
                        Console.WriteLine("Tyvärr gissade du för lågt, Gissa gärna igen!");
                    }
                    if (userNumberGuess > number) // if userNumberGuess is higher than Random number, user gets message 
                    {
                        Console.WriteLine("Tyvärr gissade du för högt, Gissa gärna igen!");
                    }
                    if (CounterGuess(counter))  // Calling the method Counterguess, If user tried 5 guesses and the method returns true, game ends with break.
                    {
                        Console.WriteLine("Nu har du gissar 5 ggr.. Tyvärr är spelet över");
                        Console.WriteLine("Tryck på vilken tangent som helst för att avsluta.");
                        Console.Read();
                        break;
                    }

                }  // Else(Not true value from user) User gets message that inputUser is not accepted. try again
                else
                {
                    Console.WriteLine($"Oj! ({inputUser}) som du gissade på är inte ett heltal,\n Försök igen..");
                }


            }


        }

            static int RandomintGenerator()// Method for Random number between 1 - 20. Return value to int number.
            {
                Random random = new Random();
                int number = random.Next(1, 21);
                return number;
            }

            static bool CounterGuess(int counter) // Boolian Method, if counter is less or the same as 5 returns false. else return true.
            {
                if (counter <= 5)
                {
                    return false;
                }
                return true;
            }


    }
}