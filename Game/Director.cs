using System;

namespace cse210_hilo.Game
{
    
    /// <summary> 
    /// Directing the game, and displaying the game, and holding score
    /// </summary>
    public class Director
    {
        bool isPlaying = true;
        string gameContinue = "y";
        string guessNextCard = "";
        int score;
        Card card = new Card();
        
        
        public Director()
        {

        }


        /// <summary> 
        /// Starts game
        /// </summary>
        public void StartGame()
        {
            score = 300;
            while(isPlaying)
            {
                card.DrawCard();
                DoOutput();
                DoUpdate();
                if (HasLoser())
                {
                    isPlaying = false;
                    return;
                }
                GetPlayAgain();
            }
        }
        
        /// <summary> 
        /// Asks user for their guess for the next card
        /// </summary>
        public void GetGuess()
        {
            Console.Write("Do you want to guess higher or lower? [h/l] ");
            guessNextCard = Console.ReadLine();
        }
        
        /// <summary> 
        /// Asks user if they want to play again
        /// </summary>
        public void GetPlayAgain()
        {
            Console.Write("Do you want to play again? [y/n]");
            string keepPlaying = Console.ReadLine();
            isPlaying = (keepPlaying == "y");
            Console.WriteLine("");

        }
        
        /// <summary> 
        /// Shows user the cards that were drawn and calls GetGuess() method
        /// </summary>
        public void DoOutput()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"The first card is: {card.firstCard}");
            GetGuess();
            Console.WriteLine($"The next card was: {card.secondCard}");

        }
        
        /// <summary> 
        /// checks if the player has lost (i.e. he/she has no points left)
        /// </summary>
        public bool HasLoser()
        {
            if (score <= 0)
            {
                return true;
            }
            else{
                return false;
            }
        }
        
        /// <summary> 
        /// updates score and displays new score
        /// </summary>
        public void DoUpdate()
        {
            if (card.firstCard < card.secondCard && guessNextCard == "h" || card.firstCard > card.secondCard && guessNextCard == "l"){
                score += 100;
            }
            else if (card.firstCard == card.secondCard){  //CONSIDER CHANGING ACCORDING TO SAME CARD RULES
                score += 0;
            }
            else{
                score -= 75;
            }
            Console.WriteLine($"Your new score is: {score} ");
        }

        
    }


}


