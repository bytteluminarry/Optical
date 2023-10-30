namespace Optical
{
    partial class PrescriptionDetails
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
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelNotes = new Label();
            labelLensType = new Label();
            labelPatient = new Label();
            buttonDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowFrame;
            pictureBox1.Location = new Point(22, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 3);
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(90, 90, 90);
            label5.Location = new Point(22, 32);
            label5.Name = "label5";
            label5.Size = new Size(184, 32);
            label5.TabIndex = 63;
            label5.Text = "PRESCRIPTION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(90, 90, 90);
            label1.Location = new Point(37, 100);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 65;
            label1.Text = "Patient : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(90, 90, 90);
            label2.Location = new Point(37, 143);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 66;
            label2.Text = "Lens Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(90, 90, 90);
            label3.Location = new Point(37, 184);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 67;
            label3.Text = "Notes : ";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotes.ForeColor = Color.FromArgb(90, 90, 90);
            labelNotes.Location = new Point(135, 187);
            labelNotes.MaximumSize = new Size(250, 0);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(0, 19);
            labelNotes.TabIndex = 68;
            // 
            // labelLensType
            // 
            labelLensType.AutoSize = true;
            labelLensType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelLensType.ForeColor = Color.FromArgb(90, 90, 90);
            labelLensType.Location = new Point(135, 146);
            labelLensType.MaximumSize = new Size(300, 0);
            labelLensType.Name = "labelLensType";
            labelLensType.Size = new Size(0, 19);
            labelLensType.TabIndex = 69;
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatient.ForeColor = Color.FromArgb(90, 90, 90);
            labelPatient.Location = new Point(135, 103);
            labelPatient.MaximumSize = new Size(300, 0);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(0, 19);
            labelPatient.TabIndex = 70;
            // 
            // buttonDetails
            // 
            buttonDetails.BackColor = Color.CornflowerBlue;
            buttonDetails.FlatAppearance.BorderSize = 0;
            buttonDetails.FlatStyle = FlatStyle.Flat;
            buttonDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDetails.ForeColor = Color.White;
            buttonDetails.Location = new Point(37, 431);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(353, 38);
            buttonDetails.TabIndex = 72;
            buttonDetails.Text = "View patient details";
            buttonDetails.UseVisualStyleBackColor = false;
            // 
            // PrescriptionDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(426, 493);
            Controls.Add(buttonDetails);
            Controls.Add(labelPatient);
            Controls.Add(labelLensType);
            Controls.Add(labelNotes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PrescriptionDetails";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelNotes;
        private Label labelLensType;
        private Label labelPatient;
        private Button buttonDetails;
    }
}