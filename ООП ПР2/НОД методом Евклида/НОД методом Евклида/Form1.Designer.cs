namespace НОД_методом_Евклида
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(15, 37);
            this.FirstNumber.MinimumSize = new System.Drawing.Size(160, 0);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(160, 22);
            this.FirstNumber.TabIndex = 0;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(15, 91);
            this.SecondNumber.MinimumSize = new System.Drawing.Size(160, 0);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(160, 22);
            this.SecondNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.MinimumSize = new System.Drawing.Size(160, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите первое число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.MinimumSize = new System.Drawing.Size(160, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите второе число";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Result.Location = new System.Drawing.Point(15, 161);
            this.Result.MinimumSize = new System.Drawing.Size(160, 22);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(160, 22);
            this.Result.TabIndex = 4;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(15, 119);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(160, 30);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Вычислить НОД";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 201);
            this.ControlBox = false;
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "НОД методом Евклида";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Calculate;
    }
}

