using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Entites;

namespace VJudgeAnalyzer.Analyzers
{
    public static class SubmissionsAnalyzer
    {
        public static void LoadSubmissions(string jsonData, int problemsCount)
        {
            JArray data = JArray.Parse(jsonData);
            for (int i = problemsCount + 5; i < data.Count(); i++)
            {
                int contestantIDX = i - 5 - problemsCount;
                IList<JToken> info = data[i].ToList();
                for (int j = 0; j < problemsCount; j++)
                {
                    int idx = j + 4;
                    string currSub = Helper.SplitByColon(info[idx].ToString());
                    string[] splittedSub = currSub.Split(new[] { "\\n " }, StringSplitOptions.None);   
                    if (splittedSub.Count() == 1)
                    {
                        if (currSub == "")
                            continue;

                        if (currSub[0] == '(')
                        {
                            for (int k = 0; k < Helper.GetSubmissionsNo(currSub); k++)
                            {
                                Submission submission = new Submission();
                                submission.Verdict = Verdicts.WA;
                                submission.problem = Data.problems[j];
                                submission.contestant = Data.contestants[contestantIDX];
                                Data.submissions.Add(submission);
                            }
                        }
                        else
                        {
                            Submission submission = new Submission();
                            submission.Verdict = Verdicts.Accepted;
                            submission.problem = Data.problems[j];
                            submission.time = currSub;
                            submission.contestant = Data.contestants[contestantIDX];
                            Data.submissions.Add(submission);
                        }
                    }
                    else
                    {
                        for (int k = 0; k < Helper.GetSubmissionsNo(splittedSub[1]); k++)
                        {
                            Submission submission = new Submission();
                            submission.Verdict = Verdicts.WA;
                            submission.problem = Data.problems[j];
                            submission.contestant = Data.contestants[contestantIDX];
                            Data.submissions.Add(submission);

                        }

                        Submission ACsubmission = new Submission();
                        ACsubmission.Verdict = Verdicts.Accepted;
                        ACsubmission.problem = Data.problems[j];
                        ACsubmission.time = splittedSub[0];
                        ACsubmission.contestant = Data.contestants[contestantIDX];
                        Data.submissions.Add(ACsubmission);
                    }
                }
            }


        }
    }
}
