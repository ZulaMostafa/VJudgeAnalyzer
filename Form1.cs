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
            Data.Tags = new List<string>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Data.problems.Clear();
                Data.contestants.Clear();
                Data.submissions.Clear();
                Data.Tags.Clear();

                int problemsCount = int.Parse(problemsCountField.Text);
                string problemsTags = problemsTagsField.Text;
                string sheetTags = sheetTagsField.Text;
                string jsonData = contestDataField.Text;
                SheetAnalyzer.AnalyzeTags(sheetTags);
                problemsAnalyzer.LoadProblems(problemsCount, problemsTags, jsonData);
                ContestantsAnalyzer.LoadContestants(jsonData, problemsCount);
                SubmissionsAnalyzer.LoadSubmissions(jsonData, problemsCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contestAnalyzerButton_Click(object sender, EventArgs e)
        {
           outputField.Text = SheetAnalyzer.AnalyzeSheet();
        }

        private void contestDataField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AwardsButton_Click(object sender, EventArgs e)
        {
            outputField.Text = ContestAwardsAnalyzer.GetAwards();
        }
    }
}
