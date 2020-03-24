using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Entites;

namespace VJudgeAnalyzer.Analyzers
{
    public static class ContestantsAnalyzer
    {
        public static void LoadContestants(string jsonData, int problemsCount)
        {
            JArray data = JArray.Parse(jsonData);
            for (int i = problemsCount + 5; i < data.Count(); i++)
            {
                Contestant contestant = new Contestant();
                contestant.Deserialize(data[i]);
                Data.contestants.Add(contestant);
            }
        }
    }
}
