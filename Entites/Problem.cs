using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Analyzers;

namespace VJudgeAnalyzer.Entites
{
    public class Problem
    {
        public string problemName, problemOrigin, letter, tag;
        public int acceptedSubmissions, totalSubmissions;
        public void Deserialize(JToken data)
        {

            IList<JToken> problemInfo = data.ToList();

            #region Stats
            string stats = Helper.SplitByColon(problemInfo[1].ToString());
            string[] splittedStats = stats.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            acceptedSubmissions = int.Parse(splittedStats[0]);
            totalSubmissions = int.Parse(splittedStats[1]);
            #endregion
            #region Letter
            letter = Helper.SplitByColon(problemInfo[2].ToString());
            #endregion
            #region Origin
            problemOrigin = Helper.SplitByColon(problemInfo[3].ToString());
            #endregion
            #region Name
            problemName = Helper.SplitByColon(problemInfo[4].ToString());
            #endregion
        }
    }
}
