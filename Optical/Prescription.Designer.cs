namespace Optical
{
    partial class Prescription
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
            buttonConfirm = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            comboBoxLensType = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            richTextBoxPrescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.RoyalBlue;
            buttonConfirm.FlatAppearance.BorderSize = 0;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(45, 418);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(364, 38);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Confirm current prescription";
            buttonConfirm.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowFrame;
            pictureBox1.Location = new Point(23, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 3);
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(90, 90, 90);
            label6.Location = new Point(23, 85);
            label6.Name = "label6";
            label6.Size = new Size(394, 67);
            label6.TabIndex = 61;
            label6.Text = "Create precise eye care prescriptions with our comprehensive form. Capture patient data, lens details, and professional recommendations seamlessly.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(90, 90, 90);
            label5.Location = new Point(23, 34);
            label5.Name = "label5";
            label5.Size = new Size(184, 32);
            label5.TabIndex = 60;
            label5.Text = "PRESCRIPTION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(45, 175);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 70;
            label1.Text = "Lens Type";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 225, 225);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxLensType);
            panel1.Location = new Point(45, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 36);
            panel1.TabIndex = 0;
            // 
            // comboBoxLensType
            // 
            comboBoxLensType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLensType.FormattingEnabled = true;
            comboBoxLensType.Location = new Point(14, 7);
            comboBoxLensType.Name = "comboBoxLensType";
            comboBoxLensType.Size = new Size(337, 23);
            comboBoxLensType.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(45, 255);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 72;
            label2.Text = "Prescription";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 225, 225);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(richTextBoxPrescription);
            panel2.Location = new Point(45, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 113);
            panel2.TabIndex = 1;
            // 
            // richTextBoxPrescription
            // 
            richTextBoxPrescription.BackColor = Color.FromArgb(205, 205, 205);
            richTextBoxPrescription.BorderStyle = BorderStyle.None;
            richTextBoxPrescription.Location = new Point(14, 12);
            richTextBoxPrescription.Name = "richTextBoxPrescription";
            richTextBoxPrescription.Size = new Size(337, 88);
            richTextBoxPrescription.TabIndex = 1;
            richTextBoxPrescription.Text = "";
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 515);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonConfirm);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Prescription";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxLensType;
        private Label label2;
        private Panel panel2;
        private RichTextBox richTextBoxPrescription;
    }
}