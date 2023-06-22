namespace НОД_равнение
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.Evklid = new System.Windows.Forms.Button();
            this.Stein = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(24, 25);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(125, 22);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "298467352";
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(155, 25);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(125, 22);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Text = "569484";
            // 
            // Evklid
            // 
            this.Evklid.Location = new System.Drawing.Point(24, 53);
            this.Evklid.Name = "Evklid";
            this.Evklid.Size = new System.Drawing.Size(125, 23);
            this.Evklid.TabIndex = 2;
            this.Evklid.Text = "Метод Евклида";
            this.Evklid.UseVisualStyleBackColor = true;
            this.Evklid.Click += new System.EventHandler(this.Evklid_Click);
            // 
            // Stein
            // 
            this.Stein.Location = new System.Drawing.Point(155, 53);
            this.Stein.Name = "Stein";
            this.Stein.Size = new System.Drawing.Size(125, 23);
            this.Stein.TabIndex = 3;
            this.Stein.Text = "Метод Штейна";
            this.Stein.UseVisualStyleBackColor = true;
            this.Stein.Click += new System.EventHandler(this.Stein_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.MinimumSize = new System.Drawing.Size(125, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 50);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(155, 79);
            this.label2.MinimumSize = new System.Drawing.Size(125, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 50);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stein);
            this.Controls.Add(this.Evklid);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "НОД сравнение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Button Evklid;
        private System.Windows.Forms.Button Stein;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

