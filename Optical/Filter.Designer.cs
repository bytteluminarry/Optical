namespace Optical
{
    partial class Filter
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
            label6 = new Label();
            label5 = new Label();
            buttonResetFilter = new Button();
            label1 = new Label();
            panel1 = new Panel();
            comboBoxPatients = new ComboBox();
            buttonApplyFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowFrame;
            pictureBox1.Location = new Point(23, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 3);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(90, 90, 90);
            label6.Location = new Point(23, 85);
            label6.Name = "label6";
            label6.Size = new Size(354, 67);
            label6.TabIndex = 21;
            label6.Text = "Tailor Your Data View: Empower Users to Customize and Personalize Information Display with Versatile Filter Options.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(90, 90, 90);
            label5.Location = new Point(23, 34);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 20;
            label5.Text = "FILTER";
            // 
            // buttonResetFilter
            // 
            buttonResetFilter.BackColor = Color.DodgerBlue;
            buttonResetFilter.FlatAppearance.BorderSize = 0;
            buttonResetFilter.FlatStyle = FlatStyle.Flat;
            buttonResetFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResetFilter.ForeColor = Color.White;
            buttonResetFilter.Location = new Point(39, 275);
            buttonResetFilter.Name = "buttonResetFilter";
            buttonResetFilter.Size = new Size(125, 38);
            buttonResetFilter.TabIndex = 2;
            buttonResetFilter.Text = "Reset filter";
            buttonResetFilter.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(39, 181);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 58;
            label1.Text = "Patient";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 225, 225);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxPatients);
            panel1.Location = new Point(39, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 36);
            panel1.TabIndex = 0;
            // 
            // comboBoxPatients
            // 
            comboBoxPatients.DropDownHeight = 250;
            comboBoxPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatients.FormattingEnabled = true;
            comboBoxPatients.IntegralHeight = false;
            comboBoxPatients.Location = new Point(14, 7);
            comboBoxPatients.Name = "comboBoxPatients";
            comboBoxPatients.Size = new Size(337, 23);
            comboBoxPatients.TabIndex = 0;
            // 
            // buttonApplyFilter
            // 
            buttonApplyFilter.BackColor = Color.RoyalBlue;
            buttonApplyFilter.FlatAppearance.BorderSize = 0;
            buttonApplyFilter.FlatStyle = FlatStyle.Flat;
            buttonApplyFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApplyFilter.ForeColor = Color.White;
            buttonApplyFilter.Location = new Point(170, 275);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(233, 38);
            buttonApplyFilter.TabIndex = 1;
            buttonApplyFilter.Text = "Apply current filter";
            buttonApplyFilter.UseVisualStyleBackColor = false;
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 398);
            Controls.Add(buttonApplyFilter);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonResetFilter);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            MaximizeBox = false;
            Name = "Filter";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Button buttonResetFilter;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxPatients;
        private Button buttonApplyFilter;
    }
}