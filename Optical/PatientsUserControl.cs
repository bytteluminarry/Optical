using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optical
{
    public partial class PatientsUserControl : UserControl
    {
        public PatientsUserControl()
        {
            InitializeComponent();
            //Setting Custom Styles to the Data Grid View
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#aaa");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            FillPatientsGridView();

            //Setting Click Event to Create Button
            buttonCreate.Click += (s, e) =>
            {
                new AddPatientForm().ShowDialog();
            };

            //Setting Click Event on Data Grid View to Trigger History Button Click foreach Row
            dataGridView1.CellContentClick += (s, e) =>
            {
                int row = e.RowIndex;
                int column = e.ColumnIndex;
                int columns_count = dataGridView1.Columns.Count;
                DataGridViewCell cell = dataGridView1.Rows[row].Cells[column];
                try
                {
                    if (cell is DataGridViewButtonCell && cell != null)
                    {
                        int id = 0;
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.HeaderText.ToLower().Trim() == "id")
                            {
                                id = Convert.ToInt32(dataGridView1.Rows[row].Cells[col.Index].Value.ToString());
                            }
                        }
                        if (dataGridView1.Rows[row].Cells[1].Value != null)
                        {
                            int patient_id = id;
                            new PatientHistory(patient_id).ShowDialog();
                        }
                    }
                }
                catch { }
            };
        }

        public void FillPatientsGridView()
        {
            Helper.conn.Open();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = null;

            SqlCommand cmd = new SqlCommand("SELECT * FROM PATIENT", Helper.conn);

            DataTable dataTable = new DataTable();

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            dataGridView1.DataSource = dataTable;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "History";
            buttonColumn.Text = "History";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle = FlatStyle.Flat;

            buttonColumn.DefaultCellStyle.BackColor = Color.FromArgb(210, 210, 210);

            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.Columns[0].Visible = false;

            Helper.conn.Close();
        }
    }
}
