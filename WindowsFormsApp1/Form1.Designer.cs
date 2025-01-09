namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OptionC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OptionF = new System.Windows.Forms.RadioButton();
            this.OptionK = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResultC = new System.Windows.Forms.Label();
            this.ResultF = new System.Windows.Forms.Label();
            this.ResultK = new System.Windows.Forms.Label();
            this.templabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptionC
            // 
            this.OptionC.AutoSize = true;
            this.OptionC.Checked = true;
            this.OptionC.Location = new System.Drawing.Point(20, 81);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(58, 17);
            this.OptionC.TabIndex = 0;
            this.OptionC.TabStop = true;
            this.OptionC.Text = "Celsius";
            this.OptionC.UseVisualStyleBackColor = true;
            this.OptionC.CheckedChanged += new System.EventHandler(this.OptionC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convert from:";
            // 
            // OptionF
            // 
            this.OptionF.AutoSize = true;
            this.OptionF.Location = new System.Drawing.Point(20, 104);
            this.OptionF.Name = "OptionF";
            this.OptionF.Size = new System.Drawing.Size(75, 17);
            this.OptionF.TabIndex = 3;
            this.OptionF.Text = "Fahrenheit";
            this.OptionF.UseVisualStyleBackColor = true;
            this.OptionF.CheckedChanged += new System.EventHandler(this.OptionF_CheckedChanged);
            // 
            // OptionK
            // 
            this.OptionK.AutoSize = true;
            this.OptionK.Location = new System.Drawing.Point(20, 127);
            this.OptionK.Name = "OptionK";
            this.OptionK.Size = new System.Drawing.Size(54, 17);
            this.OptionK.TabIndex = 4;
            this.OptionK.Text = "Kelvin";
            this.OptionK.UseVisualStyleBackColor = true;
            this.OptionK.CheckedChanged += new System.EventHandler(this.OptionK_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ResultC
            // 
            this.ResultC.AutoSize = true;
            this.ResultC.Location = new System.Drawing.Point(84, 205);
            this.ResultC.Name = "ResultC";
            this.ResultC.Size = new System.Drawing.Size(10, 13);
            this.ResultC.TabIndex = 6;
            this.ResultC.Text = "-";
            this.ResultC.Click += new System.EventHandler(this.ResultC_Click);
            // 
            // ResultF
            // 
            this.ResultF.AutoSize = true;
            this.ResultF.Location = new System.Drawing.Point(84, 218);
            this.ResultF.Name = "ResultF";
            this.ResultF.Size = new System.Drawing.Size(10, 13);
            this.ResultF.TabIndex = 6;
            this.ResultF.Text = "-";
            this.ResultF.Click += new System.EventHandler(this.ResultF_Click);
            // 
            // ResultK
            // 
            this.ResultK.AutoSize = true;
            this.ResultK.Location = new System.Drawing.Point(84, 231);
            this.ResultK.Name = "ResultK";
            this.ResultK.Size = new System.Drawing.Size(10, 13);
            this.ResultK.TabIndex = 6;
            this.ResultK.Text = "-";
            this.ResultK.Click += new System.EventHandler(this.ResultK_Click);
            // 
            // templabel
            // 
            this.templabel.AutoSize = true;
            this.templabel.Location = new System.Drawing.Point(203, 85);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(170, 13);
            this.templabel.TabIndex = 7;
            this.templabel.Text = "Please enter the temperature here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Celsius:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fahrenheit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kelvin:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "GitHub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.templabel);
            this.Controls.Add(this.ResultK);
            this.Controls.Add(this.ResultF);
            this.Controls.Add(this.ResultC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OptionK);
            this.Controls.Add(this.OptionF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptionC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton OptionC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton OptionF;
        private System.Windows.Forms.RadioButton OptionK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ResultC;
        private System.Windows.Forms.Label ResultF;
        private System.Windows.Forms.Label ResultK;
        private System.Windows.Forms.Label templabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

