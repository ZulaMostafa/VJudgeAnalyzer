using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJudgeAnalyzer.Entites
{
    public enum Verdicts {
        WA = 0,
        Accepted = 1,
    }
    public class Submission
    {
        public Contestant contestant;
        public Problem problem;
        public Verdicts Verdict;
        public string time;

        public void Deserialize(JToken data)
        {
            IList<JToken> submissionInfo = data.ToList();
        }
    }
}
