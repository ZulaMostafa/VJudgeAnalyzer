using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VJudgeAnalyzer.Analyzers
{
    public static class Helper
    {
        public static string splitByColon(string x)
        {
            string[] splittedString = x.Split(new string[] { ": " }, StringSplitOptions.None);
            if (splittedString.Length < 2)
                return "";
            string ret = splittedString[1];
            string[] splittedRet = ret.Split(new string[] { "\"" }, StringSplitOptions.None);
            return splittedRet[1];
        }
    }
}
