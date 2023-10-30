namespace Optical
{
    partial class LoginPage
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
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            textBoxUsername = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(90, 90, 90);
            label6.Location = new Point(23, 85);
            label6.Name = "label6";
            label6.Size = new Size(326, 53);
            label6.TabIndex = 18;
            label6.Text = "Access your account to efficiently manage patient records, review medical histories, and more...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(90, 90, 90);
            label5.Location = new Point(23, 34);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 17;
            label5.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.WindowFrame;
            pictureBox1.Location = new Point(23, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 3);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(40, 171);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 25;
            label1.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 225, 225);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxUsername);
            panel1.Location = new Point(40, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 36);
            panel1.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(225, 225, 225);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(23, 8);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(247, 20);
            textBoxUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(40, 251);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 27;
            label2.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 225, 225);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxPassword);
            panel2.Location = new Point(40, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 36);
            panel2.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(225, 225, 225);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(23, 8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(247, 20);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.RoyalBlue;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(40, 341);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(293, 38);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login to your account";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 482);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxUsername;
        private Label label2;
        private Panel panel2;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}