using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Entites;

namespace VJudgeAnalyzer.Analyzers
{
    public static class SheetAnalyzer
    {
        public static void AnalyzeTags(string Tags)
        {
            string[] SplittedTags = Tags.Split(',');
            foreach (string tag in SplittedTags)
            {
                Data.Tags.Add(tag.Trim());
            }
        }

        public static string AnalyzeSheet()
        {
            string ret = "";
            ret += "Rank\t";
            ret += "Name\t";
            ret += "Total Penalty\t";
            ret += "Total Time\t";
            ret += "Total Submissions\t";
            ret += "Accepted Problems\t";
            ret += "Wrong Submissions\t";
            ret += "Average Ratio\t";
            ret += "A/T Ratio\t";
            foreach (var problem in Data.problems)
                ret += problem.letter + "\t";
            foreach (var tag in Data.Tags)
                ret += tag + "\t";
            ret += "\n";
            foreach (Contestant contestant in Data.contestants)
            {
                string rank = contestant.rank.ToString();
                ret += rank + "\t";

                string name = contestant.handle;
                ret += name + "\t";

                string totalPenalty = contestant.totalPenalty.ToString();
                ret += totalPenalty + "\t";

                string totalTime = contestant.totalTime.ToString();
                ret += totalTime + "\t";

                var acceptedProblems = Data.submissions.Where(x => x.contestant == contestant && x.Verdict == Verdicts.Accepted);
                var wrongSubmissions = Data.submissions.Where(x => x.contestant == contestant && x.Verdict == Verdicts.WA);
                ret += (acceptedProblems.Count() + wrongSubmissions.Count()).ToString() + "\t"; // Total Submissions count
                ret += acceptedProblems.Count().ToString() + "\t"; // Total accepted problems count
                ret += wrongSubmissions.Count().ToString() + "\t"; // Total Wrong Submissions Count
                ret += (((double)acceptedProblems.Count() / (double)Data.problems.Count()) * 100.0).ToString() + "%\t"; // Accepted problems ratio
                ret += acceptedProblems.Count().ToString() + " / " + (acceptedProblems.Count() + wrongSubmissions.Count()).ToString() + "\t";

                for (int i = 0; i < Data.problems.Count(); i++)
                {
                    if (acceptedProblems.Where(x => x.problem == Data.problems[i]).Count() > 0)
                        ret += "YES\t";
                    else
                        ret += "NO\t";
                }

                foreach (var tag in Data.Tags)
                {
                    int acceptedTagsCount = acceptedProblems.Where(x => x.problem.tag == tag).Count();
                    ret += acceptedTagsCount.ToString() + "\t";
                }

                ret += "\n";
            }

            return ret;
        }
    }
}
