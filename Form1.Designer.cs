namespace VJudgeAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.problemsCountField = new System.Windows.Forms.TextBox();
            this.problemsTagsField = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputField = new System.Windows.Forms.RichTextBox();
            this.contestAnalyzerButton = new System.Windows.Forms.Button();
            this.AwardsButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sheetTagsField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contestIDField = new System.Windows.Forms.TextBox();
            this.usernameFieldF = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordFieldF = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problems Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Problem Tags:";
            // 
            // problemsCountField
            // 
            this.problemsCountField.Location = new System.Drawing.Point(451, 72);
            this.problemsCountField.Name = "problemsCountField";
            this.problemsCountField.Size = new System.Drawing.Size(175, 22);
            this.problemsCountField.TabIndex = 3;
            this.problemsCountField.TextChanged += new System.EventHandler(this.problemsCountField_TextChanged);
            // 
            // problemsTagsField
            // 
            this.problemsTagsField.Location = new System.Drawing.Point(163, 230);
            this.problemsTagsField.Name = "problemsTagsField";
            this.problemsTagsField.Size = new System.Drawing.Size(513, 173);
            this.problemsTagsField.TabIndex = 4;
            this.problemsTagsField.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output:";
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(163, 426);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(513, 173);
            this.outputField.TabIndex = 7;
            this.outputField.Text = "";
            // 
            // contestAnalyzerButton
            // 
            this.contestAnalyzerButton.Location = new System.Drawing.Point(431, 648);
            this.contestAnalyzerButton.Name = "contestAnalyzerButton";
            this.contestAnalyzerButton.Size = new System.Drawing.Size(245, 23);
            this.contestAnalyzerButton.TabIndex = 9;
            this.contestAnalyzerButton.Text = "Contest";
            this.contestAnalyzerButton.UseVisualStyleBackColor = true;
            this.contestAnalyzerButton.Click += new System.EventHandler(this.contestAnalyzerButton_Click);
            // 
            // AwardsButton
            // 
            this.AwardsButton.Location = new System.Drawing.Point(163, 648);
            this.AwardsButton.Name = "AwardsButton";
            this.AwardsButton.Size = new System.Drawing.Size(244, 23);
            this.AwardsButton.TabIndex = 10;
            this.AwardsButton.Text = "Awards";
            this.AwardsButton.UseVisualStyleBackColor = true;
            this.AwardsButton.Click += new System.EventHandler(this.AwardsButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 618);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(513, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "Analyze";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sheet Tags:";
            // 
            // sheetTagsField
            // 
            this.sheetTagsField.Location = new System.Drawing.Point(104, 116);
            this.sheetTagsField.Name = "sheetTagsField";
            this.sheetTagsField.Size = new System.Drawing.Size(522, 22);
            this.sheetTagsField.TabIndex = 14;
            this.sheetTagsField.TextChanged += new System.EventHandler(this.sheetTagsField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "ContestID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.passwordFieldF);
            this.groupBox1.Controls.Add(this.sheetTagsField);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.usernameFieldF);
            this.groupBox1.Controls.Add(this.contestIDField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.problemsCountField);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // contestIDField
            // 
            this.contestIDField.Location = new System.Drawing.Point(104, 74);
            this.contestIDField.Name = "contestIDField";
            this.contestIDField.Size = new System.Drawing.Size(175, 22);
            this.contestIDField.TabIndex = 19;
            // 
            // usernameFieldF
            // 
            this.usernameFieldF.Location = new System.Drawing.Point(104, 28);
            this.usernameFieldF.Name = "usernameFieldF";
            this.usernameFieldF.Size = new System.Drawing.Size(175, 22);
            this.usernameFieldF.TabIndex = 20;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(451, 153);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(175, 29);
            this.loginButton.TabIndex = 22;
            this.loginButton.Text = "Get Data";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordFieldF
            // 
            this.passwordFieldF.Location = new System.Drawing.Point(451, 25);
            this.passwordFieldF.Name = "passwordFieldF";
            this.passwordFieldF.PasswordChar = '*';
            this.passwordFieldF.Size = new System.Drawing.Size(175, 22);
            this.passwordFieldF.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 21);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Use Tags";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AwardsButton);
            this.Controls.Add(this.contestAnalyzerButton);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.problemsTagsField);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "VJudge Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox problemsCountField;
        private System.Windows.Forms.RichTextBox problemsTagsField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox outputField;
        private System.Windows.Forms.Button contestAnalyzerButton;
        private System.Windows.Forms.Button AwardsButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sheetTagsField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameFieldF;
        private System.Windows.Forms.TextBox contestIDField;
        private System.Windows.Forms.TextBox passwordFieldF;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

