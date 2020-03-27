using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                string problemsTags = "";

                if (Data.UseTags)
                {
                    problemsTags = problemsTagsField.Text;
                    string sheetTags = sheetTagsField.Text;
                    SheetAnalyzer.AnalyzeTags(sheetTags);
                }
                problemsAnalyzer.LoadProblems(problemsCount, problemsTags, Data.jsonData);
                ContestantsAnalyzer.LoadContestants(Data.jsonData, problemsCount);
                SubmissionsAnalyzer.LoadSubmissions(Data.jsonData, problemsCount);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.Proxy = null;
            using (var driver = new ChromeDriver(chromeOptions))
            {
                //Navigate To vjudge main page
                driver.Navigate().GoToUrl("https://vjudge.net/");
                Thread.Sleep(1000);

                //Click on login button to get the menu
                var loginButton = driver.FindElementByClassName("login");
                loginButton.Click();
                Thread.Sleep(1000);

                //getting username and password fields
                var usernameField = driver.FindElementById("login-username");
                var passwordField = driver.FindElementById("login-password");
                Thread.Sleep(1000);

                //setting values
                usernameField.SendKeys(usernameFieldF.Text);
                passwordField.SendKeys(passwordFieldF.Text);
                Thread.Sleep(1000);

                //login
                var sendButton = driver.FindElementById("btn-login");
                sendButton.Click();
                Thread.Sleep(1000);

                //Navigate to contest page
                driver.Navigate().GoToUrl("https://vjudge.net/contest/" + contestIDField.Text + "#rank");
                Thread.Sleep(3000);

                //get HTML Source
                string HTML = driver.PageSource;

                //Navigate to json converter page
                driver.Navigate().GoToUrl("https://www.convertjson.com/html-table-to-json.htm");

                //Setting data in the text area
                var HTMLField = driver.FindElementById("txt1");
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", driver.FindElementById("txt1"), HTML);
                Thread.Sleep(2000);

                //Click on convert Button
                var ConvertButton = driver.FindElementById("btnRun");
                ConvertButton.Click();
                Thread.Sleep(1000);

                //Get Json data
                var JSONField = driver.FindElementById("txta");
                Thread.Sleep(1000);
                Data.jsonData = JSONField.GetAttribute("value");
                Clipboard.SetText(Data.jsonData);

            }
        }

        private void problemsCountField_TextChanged(object sender, EventArgs e)
        {

        }

        private void sheetTagsField_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Data.UseTags = checkBox1.Checked;
        }
    }
}
