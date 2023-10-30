namespace Optical
{
    partial class EyeTestProcess
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
            pictureBoxProcess = new PictureBox();
            buttonProceed = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcess).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProcess
            // 
            pictureBoxProcess.Location = new Point(109, 64);
            pictureBoxProcess.Name = "pictureBoxProcess";
            pictureBoxProcess.Size = new Size(150, 150);
            pictureBoxProcess.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProcess.TabIndex = 31;
            pictureBoxProcess.TabStop = false;
            // 
            // buttonProceed
            // 
            buttonProceed.BackColor = Color.RoyalBlue;
            buttonProceed.FlatAppearance.BorderSize = 0;
            buttonProceed.FlatStyle = FlatStyle.Flat;
            buttonProceed.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProceed.ForeColor = Color.White;
            buttonProceed.Location = new Point(65, 391);
            buttonProceed.Name = "buttonProceed";
            buttonProceed.Size = new Size(238, 38);
            buttonProceed.TabIndex = 32;
            buttonProceed.Text = "Proceed to prescription";
            buttonProceed.UseVisualStyleBackColor = false;
            // 
            // EyeTestProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(368, 478);
            Controls.Add(buttonProceed);
            Controls.Add(pictureBoxProcess);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EyeTestProcess";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcess).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProcess;
        private Button buttonProceed;
    }
}