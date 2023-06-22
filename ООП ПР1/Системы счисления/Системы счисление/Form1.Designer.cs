namespace Системы_счисление
{
    partial class ConvertFrom
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
            this.ConvFrom = new System.Windows.Forms.TextBox();
            this.ConvTo = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvFrom
            // 
            this.ConvFrom.Location = new System.Drawing.Point(6, 81);
            this.ConvFrom.Name = "ConvFrom";
            this.ConvFrom.Size = new System.Drawing.Size(100, 27);
            this.ConvFrom.TabIndex = 0;
            this.ConvFrom.Text = "2";
            // 
            // ConvTo
            // 
            this.ConvTo.Location = new System.Drawing.Point(156, 81);
            this.ConvTo.Name = "ConvTo";
            this.ConvTo.Size = new System.Drawing.Size(100, 27);
            this.ConvTo.TabIndex = 1;
            this.ConvTo.Text = "2";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Result.Location = new System.Drawing.Point(6, 152);
            this.Result.MinimumSize = new System.Drawing.Size(250, 27);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(250, 27);
            this.Result.TabIndex = 2;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(6, 114);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(250, 29);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Перевести";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(6, 26);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(250, 27);
            this.Number.TabIndex = 4;
            this.Number.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.ConvertButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.ConvFrom);
            this.groupBox1.Controls.Add(this.ConvTo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите число";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "--->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите системы счисления:";
            // 
            // ConvertFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConvertFrom";
            this.Text = "Системы счисления";
            this.Load += new System.EventHandler(this.ConvertFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox ConvFrom;
        private TextBox ConvTo;
        private Label Result;
        private Button ConvertButton;
        private TextBox Number;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
    }
}