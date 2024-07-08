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
            ((System.ComponentModel.ISupportInitialize)CountGeneratorEmail).BeginInit();
            SuspendLayout();
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(12, 12);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PlaceholderText = "Enter Email";
            TextBoxEmail.Size = new Size(325, 23);
            TextBoxEmail.TabIndex = 0;
            TextBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // Log
            // 
            Log.BackColor = SystemColors.ControlLight;
            Log.BorderStyle = BorderStyle.None;
            Log.Location = new Point(12, 70);
            Log.Name = "Log";
            Log.Size = new Size(325, 240);
            Log.TabIndex = 1;
            Log.Text = "";
            // 
            // CountGeneratorEmail
            // 
            CountGeneratorEmail.Location = new Point(267, 41);
            CountGeneratorEmail.Name = "CountGeneratorEmail";
            CountGeneratorEmail.Size = new Size(70, 23);
            CountGeneratorEmail.TabIndex = 2;
            // 
            // StartGenerator
            // 
            StartGenerator.FlatAppearance.BorderColor = Color.Gray;
            StartGenerator.FlatStyle = FlatStyle.Flat;
            StartGenerator.Location = new Point(12, 41);
            StartGenerator.Name = "StartGenerator";
            StartGenerator.Size = new Size(249, 23);
            StartGenerator.TabIndex = 3;
            StartGenerator.Text = "Start Generator";
            StartGenerator.UseVisualStyleBackColor = true;
            StartGenerator.Click += StartGenerator_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(349, 322);
            Controls.Add(StartGenerator);
            Controls.Add(CountGeneratorEmail);
            Controls.Add(Log);
            Controls.Add(TextBoxEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gmail Suffix Generator";
            ((System.ComponentModel.ISupportInitialize)CountGeneratorEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxEmail;
        private RichTextBox Log;
        private NumericUpDown CountGeneratorEmail;
        private Button StartGenerator;
    }
}