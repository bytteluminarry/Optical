namespace Optical
{
    partial class EyeTestUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EyeTestUserControl));
            container = new Panel();
            buttonFilter = new Button();
            buttonCreate = new Button();
            label6 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // container
            // 
            container.BackColor = Color.FromArgb(215, 215, 215);
            container.Controls.Add(buttonFilter);
            container.Controls.Add(buttonCreate);
            container.Controls.Add(label6);
            container.Controls.Add(label5);
            container.Dock = DockStyle.Top;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Size = new Size(814, 205);
            container.TabIndex = 24;
            // 
            // buttonFilter
            // 
            buttonFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFilter.BackColor = Color.DodgerBlue;
            buttonFilter.FlatAppearance.BorderSize = 0;
            buttonFilter.FlatStyle = FlatStyle.Flat;
            buttonFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFilter.ForeColor = Color.White;
            buttonFilter.Location = new Point(590, 152);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(63, 38);
            buttonFilter.TabIndex = 31;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCreate.BackColor = Color.RoyalBlue;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(659, 152);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(139, 38);
            buttonCreate.TabIndex = 30;
            buttonCreate.Text = "Create Eye Test";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(50, 50, 50);
            label6.Location = new Point(73, 73);
            label6.Name = "label6";
            label6.Size = new Size(648, 64);
            label6.TabIndex = 22;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(50, 50, 50);
            label5.Location = new Point(30, 27);
            label5.Name = "label5";
            label5.Size = new Size(368, 37);
            label5.TabIndex = 21;
            label5.Text = "-- Eye Tests Management --";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(230, 230, 230);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(814, 288);
            dataGridView1.TabIndex = 26;
            // 
            // EyeTestUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(container);
            Name = "EyeTestUserControl";
            Size = new Size(814, 493);
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel container;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private Button buttonCreate;
        private Button buttonFilter;
    }
}
