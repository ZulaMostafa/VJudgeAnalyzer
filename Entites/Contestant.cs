using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Analyzers;

namespace VJudgeAnalyzer.Entites
{
    public class Contestant
    {
        public string handle, name, totalTime;
        public int rank, totalPenalty;

        public void Deserialize(JToken data)
        {
            IList<JToken> contestantInfo = data.ToList();

            #region Rank
            rank = int.Parse(Helper.SplitByColon(contestantInfo[0].ToString()));
            #endregion
            #region Name & Handle
            string stat = Helper.SplitByColon(contestantInfo[1].ToString());
            string[] splittedStat = stat.Split(' ');
            handle = splittedStat[0];
            if (splittedStat.Length > 1)
                name = splittedStat[1];
            #endregion
            #region Time & Penalty
            string origin = Helper.SplitByColon(contestantInfo[3].ToString());
            string[] splittedOrigin = origin.Split(new string[] { "   " }, StringSplitOptions.RemoveEmptyEntries);
            totalPenalty = int.Parse(splittedOrigin[0]);
            totalTime = splittedOrigin[1];
            #endregion
        }
    }
}
