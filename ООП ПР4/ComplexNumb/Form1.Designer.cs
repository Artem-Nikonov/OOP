namespace ComplexNumb
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
            this.A1 = new System.Windows.Forms.TextBox();
            this.I1 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.I2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(12, 15);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(125, 27);
            this.A1.TabIndex = 0;
            // 
            // I1
            // 
            this.I1.Location = new System.Drawing.Point(168, 16);
            this.I1.Name = "I1";
            this.I1.Size = new System.Drawing.Size(125, 27);
            this.I1.TabIndex = 1;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(399, 16);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(125, 27);
            this.A2.TabIndex = 2;
            // 
            // I2
            // 
            this.I2.Location = new System.Drawing.Point(555, 16);
            this.I2.Name = "I2";
            this.I2.Size = new System.Drawing.Size(125, 27);
            this.I2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(299, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "i";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(530, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(686, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "i =";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(719, 16);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(275, 27);
            this.res.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 224);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.I2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.I1);
            this.Controls.Add(this.A1);
            this.Name = "Form1";
            this.Text = "Complex number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private TextBox a1;
        //private TextBox i1;
        //private TextBox a2;
        //private TextBox i2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox res;
        private TextBox A1;
        private TextBox I1;
        private TextBox A2;
        private TextBox I2;
    }
}