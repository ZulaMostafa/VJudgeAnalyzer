﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VJudgeAnalyzer.Entites;

namespace VJudgeAnalyzer
{
    public static class Data
    {
        public static List<Problem> problems;
        public static List<Contestant> contestants;
        public static List<Submission> submissions;
        public static List<string> Tags;
        public static string jsonData = "";
        public static bool UseTags = false;
    }
}
