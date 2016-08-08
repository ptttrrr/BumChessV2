using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumChessV2
{
    class Highscore
    {
        protected int baseScore = 1000;
        private SortedList<int, string> highscores = new SortedList<int, string>(new DuplicateScoreComparer<int>());

        public Highscore()
        {
            highscores.Add(500, "Gert");
            highscores.Add(42, "Deckard");
            highscores.Add(666, "Belsebub");
            highscores.Add(0, "Donald");
            highscores.Add(242, "Mupp");
        }


        
        public void CalculateScoreAndStore(int moves, int time, string alias)
        {
            int score = baseScore - (moves + time);

            highscores[score] = alias;
        }


        //sorting highscore, get rid of worst score if there is more than 5, returning it as a list
        public List<string> ShowHighScore()
        {
            if (highscores.Count > 5)
                highscores.RemoveAt(0);
            
            List<string> highScoreList = new List<string>();

            foreach (KeyValuePair<int, string> pair in highscores)
            {
                highScoreList.Add(pair.Key.ToString() + " points by " + pair.Value.ToString());
            }
            return highScoreList;
        }
    }
}
