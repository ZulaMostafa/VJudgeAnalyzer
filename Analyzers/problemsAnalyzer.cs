using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Entites;

namespace VJudgeAnalyzer.Analyzers
{
    public static class problemsAnalyzer
    {
        public static void LoadProblems(int problemsCount, string problemsTags, string jsonData)
        {
            JArray data = JArray.Parse(jsonData);
            string[] tags = problemsTags.Split('\n');
            for (int i = 0; i < problemsCount; i++)
            {
                Problem problem = new Problem();
                problem.Deserialize(data[i]);
                Data.problems.Add(problem);
            }
        }
    }
}
