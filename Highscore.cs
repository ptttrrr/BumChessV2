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
        private SortedDictionary<int, string> highscores = new SortedDictionary<int, string>(new DuplicateScoreComparer<int>());

        public Highscore()
        {
            highscores.Add(000, "___");
            highscores.Add(000, "___");
            highscores.Add(000, "___");
            highscores.Add(000, "___");
            highscores.Add(000, "___");
        }


        public void CalculateScoreAndStore(int moves, int time, string alias)
        {
            int score = baseScore - (moves + time);

            highscores[score] = alias;
        }


        //sorting highscore, get rid of worst score if there is more than 5, returning it as a list
        public List<string> ShowHighScore()
        {
            List<string> HighScoreList = new List<string>();

            if (highscores.Count > 5)
            {
                highscores.Remove(highscores.Keys.Last());
            }

            var list = highscores.ToList();

            foreach (KeyValuePair<int, string> pair in list)
            {
                HighScoreList.Add(pair.Value.ToString() + " " + pair.Key.ToString());
            }
            return HighScoreList;
        }
    }
}
