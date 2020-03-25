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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.problemsCountField = new System.Windows.Forms.TextBox();
            this.problemsTagsField = new System.Windows.Forms.RichTextBox();
            this.contestDataField = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputField = new System.Windows.Forms.RichTextBox();
            this.contestAnalyzerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sheetTagsField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problems Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contest Data(JSON):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Problem Tags:";
            // 
            // problemsCountField
            // 
            this.problemsCountField.Location = new System.Drawing.Point(159, 16);
            this.problemsCountField.Name = "problemsCountField";
            this.problemsCountField.Size = new System.Drawing.Size(513, 22);
            this.problemsCountField.TabIndex = 3;
            // 
            // problemsTagsField
            // 
            this.problemsTagsField.Location = new System.Drawing.Point(159, 96);
            this.problemsTagsField.Name = "problemsTagsField";
            this.problemsTagsField.Size = new System.Drawing.Size(513, 173);
            this.problemsTagsField.TabIndex = 4;
            this.problemsTagsField.Text = "";
            // 
            // contestDataField
            // 
            this.contestDataField.Location = new System.Drawing.Point(159, 293);
            this.contestDataField.Name = "contestDataField";
            this.contestDataField.Size = new System.Drawing.Size(513, 173);
            this.contestDataField.TabIndex = 5;
            this.contestDataField.Text = "";
            this.contestDataField.TextChanged += new System.EventHandler(this.contestDataField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output:";
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(159, 491);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(513, 173);
            this.outputField.TabIndex = 7;
            this.outputField.Text = "";
            // 
            // contestAnalyzerButton
            // 
            this.contestAnalyzerButton.Location = new System.Drawing.Point(427, 700);
            this.contestAnalyzerButton.Name = "contestAnalyzerButton";
            this.contestAnalyzerButton.Size = new System.Drawing.Size(245, 23);
            this.contestAnalyzerButton.TabIndex = 9;
            this.contestAnalyzerButton.Text = "Contest";
            this.contestAnalyzerButton.UseVisualStyleBackColor = true;
            this.contestAnalyzerButton.Click += new System.EventHandler(this.contestAnalyzerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Awards";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 670);
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
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sheet Tags:";
            // 
            // sheetTagsField
            // 
            this.sheetTagsField.Location = new System.Drawing.Point(159, 54);
            this.sheetTagsField.Name = "sheetTagsField";
            this.sheetTagsField.Size = new System.Drawing.Size(513, 22);
            this.sheetTagsField.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 730);
            this.Controls.Add(this.sheetTagsField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contestAnalyzerButton);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contestDataField);
            this.Controls.Add(this.problemsTagsField);
            this.Controls.Add(this.problemsCountField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VJudge Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox problemsCountField;
        private System.Windows.Forms.RichTextBox problemsTagsField;
        private System.Windows.Forms.RichTextBox contestDataField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox outputField;
        private System.Windows.Forms.Button contestAnalyzerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sheetTagsField;
    }
}

