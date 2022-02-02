using System;

namespace cse210_hilo.Game
{
    
    /// <summary> 
    /// Responsibilities: Directing the game, and displaying the game, keeping/changing score
    /// </summary>
    public class Director
    {
        bool isPlaying = true;
        string gameContinue = "y";
        string guessNextCard = "";
        int score;
        Card card = new Card();
        
        /// <summary> 
        /// Constructor
        /// </summary>
        public Director()
        {

        }


        /// <summary> 
        /// Starts game
        /// </summary>
        public void StartGame()
        {
            score = 300;                // set score to 300 to start
            while(isPlaying)            // repeat while we are playing
            {
                card.DrawCard();        // move second card value to first and draw a new card for second
                DoOutput();             // print the first card, gets guess from user, prints the second card
                DoUpdate();             // updates score, displays the gain/loss, and displays new score
                if (HasLoser())         // if the score hits 0 or lower, end game
                {
                    isPlaying = false;
                    return;
                }
                GetPlayAgain();         // asks if they want to play again
            }
        }
        
        /// <summary> 
        /// Asks user for their guess for the next card, and assigns it to guessNextCard
        /// </summary>
        public void GetGuess()
        {
                Console.Write("Do you want to guess higher or lower? [h/l] "); // prompts the user for a guess
                guessNextCard = Console.ReadLine(); //gets input and applys it to guessNextCard
        }
        
        /// <summary> 
        /// Asks user if they want to play again
        /// </summary>
        public void GetPlayAgain()
        {
            Console.Write("Do you want to play again? [y/n] "); //print play again prompt
            string keepPlaying = Console.ReadLine(); // gets input and applys it to keepPlaying
            isPlaying = (keepPlaying == "y");
            Console.WriteLine(""); // print blank line
        }
        
        /// <summary> 
        /// Shows user the cards that were drawn and calls GetGuess() method
        /// </summary>
        public void DoOutput()
        {
            if (!isPlaying) // break out if we're not gaming
            {
                return;
            }
            
            Console.WriteLine($"The first card is: {card.firstCard}"); // print the first card
            GetGuess(); // gets guess from user
            Console.WriteLine($"The next card was: {card.secondCard}"); //prints the second card

        }
        
        /// <summary>
        /// Checks if the player has lost (i.e. he/she has no points left)
        /// </summary>
        /// <returns>bool: true, if the player is a loser. false, if the player is not a loser.</returns>
        public bool HasLoser()
        {
            if (score <= 0) // there is a loser if the socre if less than or equal to zero
            {
                return true;
            }
            else{ // otherwise, there is no loser
                return false;
            }
        }
        
        /// <summary> 
        /// updates score, displays the gain/loss, and displays new score
        /// </summary>
        public void DoUpdate()
        {
            if (card.firstCard < card.secondCard && guessNextCard == "h" || card.firstCard > card.secondCard && guessNextCard == "l"){ // if correct guess
                score += 100;
                Console.WriteLine("You got it! Score +100");
            }
            else if (card.firstCard == card.secondCard){  //if same card
                score += 50;
                Console.WriteLine("It's a fluke! Score +50");
            }
            else{ //if incorrect guess
                score -= 75;
                Console.WriteLine("Wrong! Score -75");
            }

            Console.WriteLine($"Your new score is: {score} "); //print score
        }

        
    }


}


