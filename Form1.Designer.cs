namespace CalculatorWFA
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
            this.listBox_hasil = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.comboBox_op = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_hasil
            // 
            this.listBox_hasil.FormattingEnabled = true;
            this.listBox_hasil.Location = new System.Drawing.Point(12, 210);
            this.listBox_hasil.Name = "listBox_hasil";
            this.listBox_hasil.Size = new System.Drawing.Size(382, 225);
            this.listBox_hasil.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nilai A";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(128, 95);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(121, 20);
            this.textBox_B.TabIndex = 2;
            // 
            // comboBox_op
            // 
            this.comboBox_op.FormattingEnabled = true;
            this.comboBox_op.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.comboBox_op.Location = new System.Drawing.Point(128, 57);
            this.comboBox_op.Name = "comboBox_op";
            this.comboBox_op.Size = new System.Drawing.Size(121, 21);
            this.comboBox_op.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nilai B";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(128, 133);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(121, 20);
            this.textBox_A.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pengoperasian";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_op);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_hasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_hasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.ComboBox comboBox_op;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

