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
        public SortedDictionary<int, string> highScores { get; set; }

        public Highscore()
        {
            
            highScores[000] = "___";
            highScores[000] = "___";
            highScores[000] = "___";
            highScores[000] = "___";
            highScores[000] = "___";
        }


        public void CalculateScoreAndStore(int moves, int time, string alias)
        {
            int score = baseScore - (moves + time);

            highScores[score] = alias;
        }

        //sorting highscore, get rid of worst score if there is more than 5, returning it as a list
        public List<string> ShowHighScore()
        {
            List<string> HighScoreList = new List<string>();

            if (highScores.Count > 5)
            {
                highScores.Remove(highScores.Keys.Last());
            }

            var list = highScores.Keys.ToList();

            foreach (var key in list)
            {             
                HighScoreList.Add(key.ToString());
            }
            return HighScoreList;       
        }

 
    }



}
