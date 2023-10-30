namespace Optical
{
    partial class AddEyeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEyeTest));
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            comboBoxPatient = new ComboBox();
            buttonViewInformation = new Button();
            label2 = new Label();
            panel2 = new Panel();
            comboBoxEye = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            textBoxSphericalPower = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            textBoxCylinderPower = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            textBoxAxis = new TextBox();
            label8 = new Label();
            panel6 = new Panel();
            textBoxVisualAcuity = new TextBox();
            label9 = new Label();
            panel7 = new Panel();
            textBoxIntraocularPressure = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            buttonAddEyeTest = new Button();
            buttonCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowFrame;
            pictureBox1.Location = new Point(23, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 3);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(90, 90, 90);
            label6.Location = new Point(23, 85);
            label6.Name = "label6";
            label6.Size = new Size(656, 94);
            label6.TabIndex = 33;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(90, 90, 90);
            label5.Location = new Point(23, 34);
            label5.Name = "label5";
            label5.Size = new Size(192, 32);
            label5.TabIndex = 32;
            label5.Text = "EYE TEST FORM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(51, 193);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 53;
            label1.Text = "Patient";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 225, 225);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxPatient);
            panel1.Location = new Point(51, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 36);
            panel1.TabIndex = 0;
            // 
            // comboBoxPatient
            // 
            comboBoxPatient.DropDownHeight = 250;
            comboBoxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatient.FormattingEnabled = true;
            comboBoxPatient.IntegralHeight = false;
            comboBoxPatient.Location = new Point(14, 7);
            comboBoxPatient.Name = "comboBoxPatient";
            comboBoxPatient.Size = new Size(157, 23);
            comboBoxPatient.TabIndex = 0;
            // 
            // buttonViewInformation
            // 
            buttonViewInformation.BackColor = Color.CornflowerBlue;
            buttonViewInformation.FlatAppearance.BorderSize = 0;
            buttonViewInformation.FlatStyle = FlatStyle.Flat;
            buttonViewInformation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewInformation.ForeColor = Color.White;
            buttonViewInformation.Location = new Point(266, 216);
            buttonViewInformation.Name = "buttonViewInformation";
            buttonViewInformation.Size = new Size(89, 38);
            buttonViewInformation.TabIndex = 9;
            buttonViewInformation.Text = "Details";
            buttonViewInformation.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(51, 273);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 56;
            label2.Text = "Which Eye";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 225, 225);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxEye);
            panel2.Location = new Point(51, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 36);
            panel2.TabIndex = 1;
            // 
            // comboBoxEye
            // 
            comboBoxEye.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEye.FormattingEnabled = true;
            comboBoxEye.Location = new Point(14, 7);
            comboBoxEye.Name = "comboBoxEye";
            comboBoxEye.Size = new Size(157, 23);
            comboBoxEye.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(266, 273);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 58;
            label3.Text = "Spherical Power";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 225, 225);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxSphericalPower);
            panel3.Location = new Point(266, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 36);
            panel3.TabIndex = 2;
            // 
            // textBoxSphericalPower
            // 
            textBoxSphericalPower.BackColor = Color.FromArgb(225, 225, 225);
            textBoxSphericalPower.BorderStyle = BorderStyle.None;
            textBoxSphericalPower.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSphericalPower.Location = new Point(14, 8);
            textBoxSphericalPower.Name = "textBoxSphericalPower";
            textBoxSphericalPower.Size = new Size(157, 20);
            textBoxSphericalPower.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(80, 80, 80);
            label4.Location = new Point(481, 273);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 60;
            label4.Text = "Cylinder Power";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(225, 225, 225);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBoxCylinderPower);
            panel4.Location = new Point(481, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 36);
            panel4.TabIndex = 3;
            // 
            // textBoxCylinderPower
            // 
            textBoxCylinderPower.BackColor = Color.FromArgb(225, 225, 225);
            textBoxCylinderPower.BorderStyle = BorderStyle.None;
            textBoxCylinderPower.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCylinderPower.Location = new Point(14, 8);
            textBoxCylinderPower.Name = "textBoxCylinderPower";
            textBoxCylinderPower.Size = new Size(157, 20);
            textBoxCylinderPower.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(80, 80, 80);
            label7.Location = new Point(266, 353);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 62;
            label7.Text = "Axis Value";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 225, 225);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBoxAxis);
            panel5.Location = new Point(266, 379);
            panel5.Name = "panel5";
            panel5.Size = new Size(184, 36);
            panel5.TabIndex = 5;
            // 
            // textBoxAxis
            // 
            textBoxAxis.BackColor = Color.FromArgb(225, 225, 225);
            textBoxAxis.BorderStyle = BorderStyle.None;
            textBoxAxis.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAxis.Location = new Point(14, 8);
            textBoxAxis.Name = "textBoxAxis";
            textBoxAxis.Size = new Size(157, 20);
            textBoxAxis.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(80, 80, 80);
            label8.Location = new Point(51, 353);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 64;
            label8.Text = "Visual Acuity";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 225, 225);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(textBoxVisualAcuity);
            panel6.Location = new Point(51, 379);
            panel6.Name = "panel6";
            panel6.Size = new Size(184, 36);
            panel6.TabIndex = 4;
            // 
            // textBoxVisualAcuity
            // 
            textBoxVisualAcuity.BackColor = Color.FromArgb(225, 225, 225);
            textBoxVisualAcuity.BorderStyle = BorderStyle.None;
            textBoxVisualAcuity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVisualAcuity.Location = new Point(14, 8);
            textBoxVisualAcuity.Name = "textBoxVisualAcuity";
            textBoxVisualAcuity.Size = new Size(157, 20);
            textBoxVisualAcuity.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(80, 80, 80);
            label9.Location = new Point(481, 353);
            label9.Name = "label9";
            label9.Size = new Size(162, 21);
            label9.TabIndex = 66;
            label9.Text = "Intraocular Pressure";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(225, 225, 225);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(textBoxIntraocularPressure);
            panel7.Location = new Point(481, 379);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 36);
            panel7.TabIndex = 6;
            // 
            // textBoxIntraocularPressure
            // 
            textBoxIntraocularPressure.BackColor = Color.FromArgb(225, 225, 225);
            textBoxIntraocularPressure.BorderStyle = BorderStyle.None;
            textBoxIntraocularPressure.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIntraocularPressure.Location = new Point(14, 8);
            textBoxIntraocularPressure.Name = "textBoxIntraocularPressure";
            textBoxIntraocularPressure.Size = new Size(157, 20);
            textBoxIntraocularPressure.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(230, 230, 230);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(726, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(500, 538);
            dataGridView1.TabIndex = 67;
            // 
            // Column1
            // 
            Column1.HeaderText = "Eye";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "SP";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "CP";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "VA";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Axis";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "IP";
            Column6.Name = "Column6";
            // 
            // buttonAddEyeTest
            // 
            buttonAddEyeTest.BackColor = Color.DodgerBlue;
            buttonAddEyeTest.FlatAppearance.BorderSize = 0;
            buttonAddEyeTest.FlatStyle = FlatStyle.Flat;
            buttonAddEyeTest.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEyeTest.ForeColor = Color.White;
            buttonAddEyeTest.Location = new Point(383, 216);
            buttonAddEyeTest.Name = "buttonAddEyeTest";
            buttonAddEyeTest.Size = new Size(282, 38);
            buttonAddEyeTest.TabIndex = 7;
            buttonAddEyeTest.Text = "Add eye test";
            buttonAddEyeTest.UseVisualStyleBackColor = false;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.RoyalBlue;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(51, 439);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(614, 38);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create new eye test record";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // AddEyeTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1226, 538);
            Controls.Add(buttonCreate);
            Controls.Add(buttonAddEyeTest);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(panel7);
            Controls.Add(label8);
            Controls.Add(panel6);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(buttonViewInformation);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEyeTest";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxPatient;
        private Button buttonViewInformation;
        private Label label2;
        private Panel panel2;
        private ComboBox comboBoxEye;
        private Label label3;
        private Panel panel3;
        private TextBox textBoxSphericalPower;
        private Label label4;
        private Panel panel4;
        private TextBox textBoxCylinderPower;
        private Label label7;
        private Panel panel5;
        private TextBox textBoxAxis;
        private Label label8;
        private Panel panel6;
        private TextBox textBoxVisualAcuity;
        private Label label9;
        private Panel panel7;
        private TextBox textBoxIntraocularPressure;
        private DataGridView dataGridView1;
        private Button buttonAddEyeTest;
        private Button buttonCreate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}