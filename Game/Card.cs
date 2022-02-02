using System;

namespace cse210_hilo.Game{
    
    public class Card{
        // Director director = new Director();

        public int firstCard;
        public int secondCard;
        // public string GetScore = "hi";

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

        public void DrawCard(){
            firstCard = secondCard;
            secondCard = RandomCard();
        }

            bool isodd = false;
        private int RandomCard(){
            // Add code here
            // See if this is useful:
            // https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
            /*  --  Test --
            */
            isodd = !isodd;
            if (isodd){
            return 6; // change "6" to the value

            }
            else{
                return 5;
            }
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