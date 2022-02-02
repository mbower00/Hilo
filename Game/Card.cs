using System;

namespace cse210_hilo.Game{
    
    /// <summary>
    /// Responsibilities: keeps track of cards, drawing a new card
    /// </summary>
    public class Card{
        // Director director = new Director();

        public int firstCard;
        public int secondCard;
        // public string GetScore = "hi";

        
        /// <summary> 
        /// Constructor (first card could be set to anything, but we have it as 0, second card is set to random)
        /// </summary>
        public Card()
        {
            firstCard = 0;
            secondCard = RandomCard(); //make random num
            
            /*
            if GetGuess.guess == h but h is false: score -75
            if GetGuess.guess == h but h is true: score +100
            if GetGuess.guess == l but l is false: score -75
            if GetGuess.guess == l but l is true: score +100

            */
            //Console.WriteLine("The score is: " + director.score);
            //director.score = 100;
            //Console.WriteLine("The score is now: " + director.score);

        }

        /// <summary> 
        /// moves the secondCard value to firstCard and picks a new random value for secondCard
        /// </summary>
        public void DrawCard(){
            firstCard = secondCard; //apply 2nd to 1st
            secondCard = RandomCard(); //apply random to 2nd
        }

            /* -- Test --
            bool isodd = false;*/
        
        /// <summary>
        /// Selects a random value from 1 through 13 and returns it.
        /// </summary>
        /// <returns>A random value from 1 through 13</returns>
        private int RandomCard(){
            Random random = new Random();
            int value = random.Next(1,14);
            return value;
            //this opporation will be called back to the previous RandomCard()
            //'random' is being randomized to be called our new random
            // then we can set the int randomcard() to randomly generate a number from 1 to 13
            // now that it will be called back with that randomly generated number for the first and second card
            // With those values, it can be awarded or deducted pionts according to if its hi or lo

            // Add code here
            // See if this is useful:
            // https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
            /*  --  Test --
            isodd = !isodd;
            if (isodd){
            return 6; // change "6" to the value

            }
            else{
                return 5;
            }
            */
        }

    }
}


/*
firstCard  --  atribute: Random INT 1-13
secondCard  --  atribute: Random INT 1-13   --  not what firstCard is.
GetScore  --  atribute: 
*/

/*  --Da Rules--
The player starts the game with 300 points.
Individual cards are represented as a number from 1 to 13.
The current card is displayed.
The player guesses if the next one will be higher or lower.
The the next card is displayed.
The player earns 100 points if they guessed correctly.
The player loses 75 points if they guessed incorrectly.
If a player reaches 0 points the game is over.
If a player has more than 0 points they decide if they want to keep playing.
If a player decides not to play again the game is over.
*/