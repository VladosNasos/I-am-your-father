namespace I_am_your_father
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
            VaderTextBox = new TextBox();
            SuspendLayout();
            // 
            // VaderTextBox
            // 
            VaderTextBox.Location = new Point(12, 14);
            VaderTextBox.Name = "VaderTextBox";
            VaderTextBox.Size = new Size(238, 23);
            VaderTextBox.TabIndex = 0;
            VaderTextBox.TextChanged += VaderTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 486);
            Controls.Add(VaderTextBox);
            Name = "Form1";
            Text = "Dart Vader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox VaderTextBox;
    }
}