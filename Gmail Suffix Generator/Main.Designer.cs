namespace Gmail_Suffix_Generator
{
    partial class Main
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
            TextBoxEmail = new TextBox();
            Log = new RichTextBox();
            CountGeneratorEmail = new NumericUpDown();
            StartGenerator = new Button();
            label1 = new Label();
            label2 = new Label();
            SuffiixLength = new NumericUpDown();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)CountGeneratorEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuffiixLength).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(12, 12);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PlaceholderText = "Enter Email";
            TextBoxEmail.Size = new Size(325, 23);
            TextBoxEmail.TabIndex = 1;
            TextBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // Log
            // 
            Log.BackColor = Color.White;
            Log.BorderStyle = BorderStyle.None;
            Log.Location = new Point(3, 14);
            Log.Name = "Log";
            Log.Size = new Size(319, 207);
            Log.TabIndex = 1;
            Log.Text = "";
            Log.TextChanged += Log_TextChanged;
            // 
            // CountGeneratorEmail
            // 
            CountGeneratorEmail.Location = new Point(239, 59);
            CountGeneratorEmail.Name = "CountGeneratorEmail";
            CountGeneratorEmail.Size = new Size(98, 23);
            CountGeneratorEmail.TabIndex = 2;
            // 
            // StartGenerator
            // 
            StartGenerator.FlatAppearance.BorderColor = Color.Gray;
            StartGenerator.FlatStyle = FlatStyle.Flat;
            StartGenerator.Location = new Point(12, 41);
            StartGenerator.Name = "StartGenerator";
            StartGenerator.Size = new Size(133, 41);
            StartGenerator.TabIndex = 0;
            StartGenerator.Text = "Start Generator";
            StartGenerator.UseVisualStyleBackColor = true;
            StartGenerator.Click += StartGenerator_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 41);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Generator Count ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 41);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "Suffiix Length";
            // 
            // SuffiixLength
            // 
            SuffiixLength.Location = new Point(151, 59);
            SuffiixLength.Name = "SuffiixLength";
            SuffiixLength.Size = new Size(82, 23);
            SuffiixLength.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Log);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 224);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(349, 322);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(SuffiixLength);
            Controls.Add(label1);
            Controls.Add(StartGenerator);
            Controls.Add(CountGeneratorEmail);
            Controls.Add(TextBoxEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gmail Suffix Generator  VER_1.1.0";
            ((System.ComponentModel.ISupportInitialize)CountGeneratorEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuffiixLength).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxEmail;
        private RichTextBox Log;
        private NumericUpDown CountGeneratorEmail;
        private Button StartGenerator;
        private Label label1;
        private Label label2;
        private NumericUpDown SuffiixLength;
        private GroupBox groupBox1;
    }
}