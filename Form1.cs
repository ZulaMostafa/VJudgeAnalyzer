using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VJudgeAnalyzer.Analyzers;

namespace VJudgeAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.problems = new List<Entites.Problem>();
            Data.contestants = new List<Entites.Contestant>();
            Data.submissions = new List<Entites.Submission>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int problemsCount = int.Parse(problemsCountField.Text);
                string problemsTags = problemsTagsField.Text;
                string jsonData = contestDataField.Text;
                problemsAnalyzer.LoadProblems(problemsCount, problemsTags, jsonData);
                ContestantsAnalyzer.LoadContestants(jsonData, problemsCount);
                SubmissionsAnalyzer.LoadSubmissions(jsonData, problemsCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
