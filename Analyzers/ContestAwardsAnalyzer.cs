using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJudgeAnalyzer.Analyzers
{
    public static class ContestAwardsAnalyzer
    {
        public static string GetAwards()
        {
            string ret = "";

            foreach (var problem in Data.problems)
            {
                var first = Data.submissions.Where(x => x.problem == problem && x.Verdict == Entites.Verdicts.Accepted)
                           .OrderBy(x => DateTime.Parse(x.time))
                           .ThenBy(x => x.contestant.rank)
                           .First();
                if (first == null)
                    continue;
                ret += "First to solve problem " + problem.letter + ": \""; 
                ret += first.contestant.handle + "\" at " + first.time + ".\n";
            }

            var firstAccepted = Data.submissions.Where(x => x.Verdict == Entites.Verdicts.Accepted)
                           .OrderBy(x => DateTime.Parse(x.time))
                           .ThenBy(x => x.contestant.rank)
                           .First();
            ret += "Extreme programmer \"First Accepted in contest\":";
            ret += "\"" + firstAccepted.contestant.handle + "\" ";
            ret += "at " + firstAccepted.time + ".\n";

            var lastAccepted = Data.submissions.Where(x => x.Verdict == Entites.Verdicts.Accepted)
                           .OrderByDescending(x => DateTime.Parse(x.time))
                           .ThenBy(x => x.contestant.rank)
                           .First();
            ret += "Steadfast Guru \"Last Accepted in contest\":";
            ret += "\"" + lastAccepted.contestant.handle + "\" ";
            ret += "at " + lastAccepted.time + ".\n";

            var solid = Data.contestants.OrderByDescending(con =>
                Data.submissions.Where(sub => sub.contestant == con && sub.Verdict == Entites.Verdicts.Accepted
                && Data.submissions.Where(sub2 => sub2.contestant == con && sub2.Verdict == Entites.Verdicts.WA && sub2.problem == sub.problem).Count() == 0)
                .Count())
                .First();
            int cnt = Data.submissions.Where(x => x.contestant == solid && x.Verdict == Entites.Verdicts.Accepted
            && Data.submissions.Where(y => y.contestant == solid && y.Verdict == Entites.Verdicts.WA && y.problem == x.problem).Count() == 0)
                .Count();
                
                
            ret += "Solid Programmer \"Most number of accepted from first time\":";
            ret += "\"" + solid.handle + "\" ";
            ret += "with " + cnt.ToString() + " problems.\n";

            var relentless = Data.submissions.Where(x => x.Verdict == Entites.Verdicts.Accepted)
                .OrderByDescending(x => 
                Data.submissions.Where(y => y.contestant == x.contestant && y.problem == x.problem && y.Verdict == Entites.Verdicts.WA)
                .Count())
                .ThenBy(x => x.contestant.rank)
                .First();
            int relentlessCnt = Data.submissions.Where(x => x.problem == relentless.problem && x.contestant == relentless.contestant && x.Verdict == Entites.Verdicts.WA)
                .Count();
            ret += "Relentless programmer \"Solved a problem after the highest number of wrong submissions\":";
            ret += "\"" + relentless.contestant.handle + "\" ";
            ret += "Accepted problem " + relentless.problem.letter + " after " + relentlessCnt.ToString() + " wrong submissions.";
            return ret;
        }
    }
}
