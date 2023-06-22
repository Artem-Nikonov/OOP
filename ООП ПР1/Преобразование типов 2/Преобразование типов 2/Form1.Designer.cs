namespace Преобразование_типов_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AsDecimal = new System.Windows.Forms.Button();
            this.AsDouble = new System.Windows.Forms.Button();
            this.AsFloat = new System.Windows.Forms.Button();
            this.AsChar = new System.Windows.Forms.Button();
            this.AsUlong = new System.Windows.Forms.Button();
            this.AsLong = new System.Windows.Forms.Button();
            this.AsUint = new System.Windows.Forms.Button();
            this.AsInt = new System.Windows.Forms.Button();
            this.AsUshort = new System.Windows.Forms.Button();
            this.AsShort = new System.Windows.Forms.Button();
            this.AsByte = new System.Windows.Forms.Button();
            this.AsSbyte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToDecimal = new System.Windows.Forms.Button();
            this.ToDouble = new System.Windows.Forms.Button();
            this.ToFloat = new System.Windows.Forms.Button();
            this.ToChar = new System.Windows.Forms.Button();
            this.ToUlong = new System.Windows.Forms.Button();
            this.ToLong = new System.Windows.Forms.Button();
            this.ToUint = new System.Windows.Forms.Button();
            this.ToInt = new System.Windows.Forms.Button();
            this.ToUshort = new System.Windows.Forms.Button();
            this.ToShort = new System.Windows.Forms.Button();
            this.ToByte = new System.Windows.Forms.Button();
            this.ToSbyte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AsIs = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AsDecimal);
            this.groupBox1.Controls.Add(this.AsDouble);
            this.groupBox1.Controls.Add(this.AsFloat);
            this.groupBox1.Controls.Add(this.AsChar);
            this.groupBox1.Controls.Add(this.AsUlong);
            this.groupBox1.Controls.Add(this.AsLong);
            this.groupBox1.Controls.Add(this.AsUint);
            this.groupBox1.Controls.Add(this.AsInt);
            this.groupBox1.Controls.Add(this.AsUshort);
            this.groupBox1.Controls.Add(this.AsShort);
            this.groupBox1.Controls.Add(this.AsByte);
            this.groupBox1.Controls.Add(this.AsSbyte);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(180, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конвертировать, как:";
            // 
            // AsDecimal
            // 
            this.AsDecimal.Location = new System.Drawing.Point(15, 411);
            this.AsDecimal.Name = "AsDecimal";
            this.AsDecimal.Size = new System.Drawing.Size(150, 29);
            this.AsDecimal.TabIndex = 11;
            this.AsDecimal.Text = "Decimal";
            this.AsDecimal.UseVisualStyleBackColor = true;
            this.AsDecimal.Click += new System.EventHandler(this.AsDecimal_Click);
            // 
            // AsDouble
            // 
            this.AsDouble.Location = new System.Drawing.Point(15, 376);
            this.AsDouble.Name = "AsDouble";
            this.AsDouble.Size = new System.Drawing.Size(150, 29);
            this.AsDouble.TabIndex = 10;
            this.AsDouble.Text = "Double";
            this.AsDouble.UseVisualStyleBackColor = true;
            this.AsDouble.Click += new System.EventHandler(this.AsDouble_Click);
            // 
            // AsFloat
            // 
            this.AsFloat.Location = new System.Drawing.Point(15, 341);
            this.AsFloat.Name = "AsFloat";
            this.AsFloat.Size = new System.Drawing.Size(150, 29);
            this.AsFloat.TabIndex = 9;
            this.AsFloat.Text = "Float";
            this.AsFloat.UseVisualStyleBackColor = true;
            this.AsFloat.Click += new System.EventHandler(this.AsFloat_Click);
            // 
            // AsChar
            // 
            this.AsChar.Location = new System.Drawing.Point(15, 306);
            this.AsChar.Name = "AsChar";
            this.AsChar.Size = new System.Drawing.Size(150, 29);
            this.AsChar.TabIndex = 8;
            this.AsChar.Text = "Char";
            this.AsChar.UseVisualStyleBackColor = true;
            this.AsChar.Click += new System.EventHandler(this.AsChar_Click);
            // 
            // AsUlong
            // 
            this.AsUlong.Location = new System.Drawing.Point(15, 271);
            this.AsUlong.Name = "AsUlong";
            this.AsUlong.Size = new System.Drawing.Size(150, 29);
            this.AsUlong.TabIndex = 7;
            this.AsUlong.Text = "Ulong";
            this.AsUlong.UseVisualStyleBackColor = true;
            this.AsUlong.Click += new System.EventHandler(this.AsUlong_Click);
            // 
            // AsLong
            // 
            this.AsLong.Location = new System.Drawing.Point(15, 236);
            this.AsLong.Name = "AsLong";
            this.AsLong.Size = new System.Drawing.Size(150, 29);
            this.AsLong.TabIndex = 6;
            this.AsLong.Text = "Long";
            this.AsLong.UseVisualStyleBackColor = true;
            this.AsLong.Click += new System.EventHandler(this.AsLong_Click);
            // 
            // AsUint
            // 
            this.AsUint.Location = new System.Drawing.Point(15, 201);
            this.AsUint.Name = "AsUint";
            this.AsUint.Size = new System.Drawing.Size(150, 29);
            this.AsUint.TabIndex = 5;
            this.AsUint.Text = "Uint";
            this.AsUint.UseVisualStyleBackColor = true;
            this.AsUint.Click += new System.EventHandler(this.AsUint_Click);
            // 
            // AsInt
            // 
            this.AsInt.Location = new System.Drawing.Point(15, 166);
            this.AsInt.Name = "AsInt";
            this.AsInt.Size = new System.Drawing.Size(150, 29);
            this.AsInt.TabIndex = 4;
            this.AsInt.Text = "Int";
            this.AsInt.UseVisualStyleBackColor = true;
            this.AsInt.Click += new System.EventHandler(this.AsInt_Click);
            // 
            // AsUshort
            // 
            this.AsUshort.Location = new System.Drawing.Point(15, 131);
            this.AsUshort.Name = "AsUshort";
            this.AsUshort.Size = new System.Drawing.Size(150, 29);
            this.AsUshort.TabIndex = 3;
            this.AsUshort.Text = "Ushort";
            this.AsUshort.UseVisualStyleBackColor = true;
            this.AsUshort.Click += new System.EventHandler(this.AsUshort_Click);
            // 
            // AsShort
            // 
            this.AsShort.Location = new System.Drawing.Point(15, 96);
            this.AsShort.Name = "AsShort";
            this.AsShort.Size = new System.Drawing.Size(150, 29);
            this.AsShort.TabIndex = 2;
            this.AsShort.Text = "Short";
            this.AsShort.UseVisualStyleBackColor = true;
            this.AsShort.Click += new System.EventHandler(this.AsShort_Click);
            // 
            // AsByte
            // 
            this.AsByte.Location = new System.Drawing.Point(15, 61);
            this.AsByte.Name = "AsByte";
            this.AsByte.Size = new System.Drawing.Size(150, 29);
            this.AsByte.TabIndex = 1;
            this.AsByte.Text = "Byte";
            this.AsByte.UseVisualStyleBackColor = true;
            this.AsByte.Click += new System.EventHandler(this.AsByte_Click);
            // 
            // AsSbyte
            // 
            this.AsSbyte.Location = new System.Drawing.Point(15, 26);
            this.AsSbyte.Name = "AsSbyte";
            this.AsSbyte.Size = new System.Drawing.Size(150, 29);
            this.AsSbyte.TabIndex = 0;
            this.AsSbyte.Text = "Sbyte";
            this.AsSbyte.UseVisualStyleBackColor = true;
            this.AsSbyte.Click += new System.EventHandler(this.AsSbyte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.MinimumSize = new System.Drawing.Size(180, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 75);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 15);
            this.label2.MinimumSize = new System.Drawing.Size(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "----->";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(254, 15);
            this.textBoxResult.MinimumSize = new System.Drawing.Size(0, 29);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(180, 29);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.Text = "0";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(254, 47);
            this.labelResult.MinimumSize = new System.Drawing.Size(180, 75);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(180, 75);
            this.labelResult.TabIndex = 5;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ToDecimal);
            this.groupBox2.Controls.Add(this.ToDouble);
            this.groupBox2.Controls.Add(this.ToFloat);
            this.groupBox2.Controls.Add(this.ToChar);
            this.groupBox2.Controls.Add(this.ToUlong);
            this.groupBox2.Controls.Add(this.ToLong);
            this.groupBox2.Controls.Add(this.ToUint);
            this.groupBox2.Controls.Add(this.ToInt);
            this.groupBox2.Controls.Add(this.ToUshort);
            this.groupBox2.Controls.Add(this.ToShort);
            this.groupBox2.Controls.Add(this.ToByte);
            this.groupBox2.Controls.Add(this.ToSbyte);
            this.groupBox2.Location = new System.Drawing.Point(254, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 451);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Преобразовать в:";
            // 
            // ToDecimal
            // 
            this.ToDecimal.Location = new System.Drawing.Point(15, 411);
            this.ToDecimal.Name = "ToDecimal";
            this.ToDecimal.Size = new System.Drawing.Size(150, 29);
            this.ToDecimal.TabIndex = 11;
            this.ToDecimal.Text = "Decimal";
            this.ToDecimal.UseVisualStyleBackColor = true;
            this.ToDecimal.Click += new System.EventHandler(this.ToDecimal_Click);
            // 
            // ToDouble
            // 
            this.ToDouble.Location = new System.Drawing.Point(15, 376);
            this.ToDouble.Name = "ToDouble";
            this.ToDouble.Size = new System.Drawing.Size(150, 29);
            this.ToDouble.TabIndex = 10;
            this.ToDouble.Text = "Double";
            this.ToDouble.UseVisualStyleBackColor = true;
            this.ToDouble.Click += new System.EventHandler(this.ToDouble_Click);
            // 
            // ToFloat
            // 
            this.ToFloat.Location = new System.Drawing.Point(15, 341);
            this.ToFloat.Name = "ToFloat";
            this.ToFloat.Size = new System.Drawing.Size(150, 29);
            this.ToFloat.TabIndex = 9;
            this.ToFloat.Text = "Float";
            this.ToFloat.UseVisualStyleBackColor = true;
            this.ToFloat.Click += new System.EventHandler(this.ToFloat_Click);
            // 
            // ToChar
            // 
            this.ToChar.Location = new System.Drawing.Point(15, 306);
            this.ToChar.Name = "ToChar";
            this.ToChar.Size = new System.Drawing.Size(150, 29);
            this.ToChar.TabIndex = 8;
            this.ToChar.Text = "Char";
            this.ToChar.UseVisualStyleBackColor = true;
            this.ToChar.Click += new System.EventHandler(this.ToChar_Click);
            // 
            // ToUlong
            // 
            this.ToUlong.Location = new System.Drawing.Point(15, 271);
            this.ToUlong.Name = "ToUlong";
            this.ToUlong.Size = new System.Drawing.Size(150, 29);
            this.ToUlong.TabIndex = 7;
            this.ToUlong.Text = "Ulong";
            this.ToUlong.UseVisualStyleBackColor = true;
            this.ToUlong.Click += new System.EventHandler(this.ToUlong_Click);
            // 
            // ToLong
            // 
            this.ToLong.Location = new System.Drawing.Point(15, 236);
            this.ToLong.Name = "ToLong";
            this.ToLong.Size = new System.Drawing.Size(150, 29);
            this.ToLong.TabIndex = 6;
            this.ToLong.Text = "Long";
            this.ToLong.UseVisualStyleBackColor = true;
            this.ToLong.Click += new System.EventHandler(this.ToLong_Click);
            // 
            // ToUint
            // 
            this.ToUint.Location = new System.Drawing.Point(15, 201);
            this.ToUint.Name = "ToUint";
            this.ToUint.Size = new System.Drawing.Size(150, 29);
            this.ToUint.TabIndex = 5;
            this.ToUint.Text = "Uint";
            this.ToUint.UseVisualStyleBackColor = true;
            this.ToUint.Click += new System.EventHandler(this.ToUint_Click);
            // 
            // ToInt
            // 
            this.ToInt.Location = new System.Drawing.Point(15, 166);
            this.ToInt.Name = "ToInt";
            this.ToInt.Size = new System.Drawing.Size(150, 29);
            this.ToInt.TabIndex = 4;
            this.ToInt.Text = "Int";
            this.ToInt.UseVisualStyleBackColor = true;
            this.ToInt.Click += new System.EventHandler(this.ToInt_Click);
            // 
            // ToUshort
            // 
            this.ToUshort.Location = new System.Drawing.Point(15, 131);
            this.ToUshort.Name = "ToUshort";
            this.ToUshort.Size = new System.Drawing.Size(150, 29);
            this.ToUshort.TabIndex = 3;
            this.ToUshort.Text = "Ushort";
            this.ToUshort.UseVisualStyleBackColor = true;
            this.ToUshort.Click += new System.EventHandler(this.ToUshort_Click);
            // 
            // ToShort
            // 
            this.ToShort.Location = new System.Drawing.Point(15, 96);
            this.ToShort.Name = "ToShort";
            this.ToShort.Size = new System.Drawing.Size(150, 29);
            this.ToShort.TabIndex = 2;
            this.ToShort.Text = "Short";
            this.ToShort.UseVisualStyleBackColor = true;
            this.ToShort.Click += new System.EventHandler(this.ToShort_Click);
            // 
            // ToByte
            // 
            this.ToByte.Location = new System.Drawing.Point(15, 61);
            this.ToByte.Name = "ToByte";
            this.ToByte.Size = new System.Drawing.Size(150, 29);
            this.ToByte.TabIndex = 1;
            this.ToByte.Text = "Byte";
            this.ToByte.UseVisualStyleBackColor = true;
            this.ToByte.Click += new System.EventHandler(this.ToByte_Click);
            // 
            // ToSbyte
            // 
            this.ToSbyte.Location = new System.Drawing.Point(15, 26);
            this.ToSbyte.Name = "ToSbyte";
            this.ToSbyte.Size = new System.Drawing.Size(150, 29);
            this.ToSbyte.TabIndex = 0;
            this.ToSbyte.Text = "Sbyte";
            this.ToSbyte.UseVisualStyleBackColor = true;
            this.ToSbyte.Click += new System.EventHandler(this.ToSbyte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.MinimumSize = new System.Drawing.Size(750, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 92);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AsIs);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(455, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 200);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AS/IS";
            // 
            // AsIs
            // 
            this.AsIs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AsIs.Location = new System.Drawing.Point(315, 165);
            this.AsIs.MinimumSize = new System.Drawing.Size(0, 29);
            this.AsIs.Name = "AsIs";
            this.AsIs.Size = new System.Drawing.Size(150, 29);
            this.AsIs.TabIndex = 9;
            this.AsIs.Text = "Преобразовать";
            this.AsIs.UseVisualStyleBackColor = true;
            this.AsIs.Click += new System.EventHandler(this.AsIs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(455, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 134);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Пользовательское преобразование типов Implicit, Explicit";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(315, 99);
            this.button1.MinimumSize = new System.Drawing.Size(0, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Преобразовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.MinimumSize = new System.Drawing.Size(750, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(750, 69);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 599);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Преобразование типов данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button AsSbyte;
        private Button AsByte;
        private Button AsDecimal;
        private Button AsDouble;
        private Button AsFloat;
        private Button AsChar;
        private Button AsUlong;
        private Button AsLong;
        private Button AsUint;
        private Button AsInt;
        private Button AsUshort;
        private Button AsShort;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private TextBox textBoxResult;
        private Label labelResult;
        private GroupBox groupBox2;
        private Button ToDecimal;
        private Button ToDouble;
        private Button ToFloat;
        private Button ToChar;
        private Button ToUlong;
        private Button ToLong;
        private Button ToUint;
        private Button ToInt;
        private Button ToUshort;
        private Button ToShort;
        private Button ToByte;
        private Button ToSbyte;
        private Label label3;
        private GroupBox groupBox3;
        private Button AsIs;
        private GroupBox groupBox4;
        private Button button1;
        private Label label4;
    }
}