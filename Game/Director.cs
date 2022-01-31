using System;

namespace Unit02.Game
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
        
        
        public Director()
        {
            int score = 300;
        }


        /// <summary> 
        /// Starts game
        /// </summary>
        public void StartGame()
        {
            while(isPlaying)
            {
                //Card card = new Card();
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
        ///
        /// </summary>
        public void GetGuess()
        {
            Console.Write("Do you want to guess higher or lower? [h/l] ");
            string guess = Console.ReadLine();
        }
        
        /// <summary> 
        ///
        /// </summary>
        public void GetPlayAgain()
        {
            Console.Write("Do you want to play again? [y/n]");
            string keepPlaying = Console.ReadLine();
            isPlaying = (keepPlaying == "y");

        }
        
        /// <summary> 
        ///
        /// </summary>
        public void DoOutput()
        {
            if (!isPlaying)
            {
                return;
            }

            //Console.WriteLine($"The first card is: {card.firstCard}");
            GetGuess();
            //Console.WriteLine($"The next card was: {card.secondCard}");

        }
        
        /// <summary> 
        /// checks if the player has lost (i.e. he/she has no points left)
        /// </summary>
        public bool HasLoser()
        {
            // if (card.GetScore() <= 0)
            // {
                 return true;
            // }
        }
        
        /// <summary> 
        /// updates and
        /// </summary>
        public void DoUpdate()
        {
            
            //Console.WriteLine($"Your new score is: {card.GetScore()} ");
        }
    }


}


