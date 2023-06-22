namespace ПР_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.material = new System.Windows.Forms.ListBox();
            this.crossSection = new System.Windows.Forms.ListBox();
            this.testResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetRes = new System.Windows.Forms.Button();
            this.tests = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // material
            // 
            this.material.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.material.FormattingEnabled = true;
            this.material.ItemHeight = 20;
            this.material.Location = new System.Drawing.Point(12, 12);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(250, 184);
            this.material.TabIndex = 0;
            this.material.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // crossSection
            // 
            this.crossSection.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.crossSection.FormattingEnabled = true;
            this.crossSection.ItemHeight = 20;
            this.crossSection.Location = new System.Drawing.Point(268, 12);
            this.crossSection.Name = "crossSection";
            this.crossSection.Size = new System.Drawing.Size(250, 184);
            this.crossSection.TabIndex = 1;
            // 
            // testResult
            // 
            this.testResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.testResult.FormattingEnabled = true;
            this.testResult.ItemHeight = 20;
            this.testResult.Location = new System.Drawing.Point(535, 12);
            this.testResult.Name = "testResult";
            this.testResult.Size = new System.Drawing.Size(250, 184);
            this.testResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 202);
            this.label1.MinimumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GetRes
            // 
            this.GetRes.Location = new System.Drawing.Point(12, 202);
            this.GetRes.Name = "GetRes";
            this.GetRes.Size = new System.Drawing.Size(250, 29);
            this.GetRes.TabIndex = 4;
            this.GetRes.Text = "Выбрать";
            this.GetRes.UseVisualStyleBackColor = true;
            this.GetRes.Click += new System.EventHandler(this.GetRes_Click);
            // 
            // tests
            // 
            this.tests.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tests.FormattingEnabled = true;
            this.tests.ItemHeight = 20;
            this.tests.Location = new System.Drawing.Point(536, 237);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(250, 184);
            this.tests.TabIndex = 5;
            this.tests.SelectedIndexChanged += new System.EventHandler(this.tests_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запустить тесты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.GetRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testResult);
            this.Controls.Add(this.crossSection);
            this.Controls.Add(this.material);
            this.Name = "Form1";
            this.Text = "Enums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox material;
        private ListBox crossSection;
        private ListBox testResult;
        private Label label1;
        private Button GetRes;
        private ListBox tests;
        private Button button1;
    }
}