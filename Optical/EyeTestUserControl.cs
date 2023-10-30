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
    public partial class EyeTestUserControl : UserControl
    {
        bool filter = false;
        int patient_id = 0;
        public EyeTestUserControl()
        {
            InitializeComponent();
            //Setting Custom Styles to the Data Grid View
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#aaa");
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            FillEyeTestsGridView();

            //Setting Click Event to Create Button
            buttonCreate.Click += (s, e) =>
            {
                new AddEyeTest().ShowDialog();
            };

            //Setting Click Event to Filter Button
            buttonFilter.Click += (s, e) =>
            {
                new Filter().ShowDialog();
            };

            //Setting Click Event on Data Grid View to Trigger Prescription Button Click foreach Row
            dataGridView1.CellContentClick += (s, e) =>
            {
                int row = e.RowIndex;
                int column = e.ColumnIndex;

                DataGridViewCell cell = dataGridView1.Rows[row].Cells[column];
                try
                {
                    if(cell is DataGridViewButtonCell && cell != null)
                    {
                        if(dataGridView1.Rows[row].Cells[14].Value != null)
                        {
                            int eye_test_id = Convert.ToInt32(dataGridView1.Rows[row].Cells[14].Value.ToString());
                            new PrescriptionDetails(eye_test_id).ShowDialog();
                        }
                    }
                }
                catch { }
            };
        }

        public void FillEyeTestsGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 15;

            dataGridView1.Columns[0].Name = "Patient Name";

            dataGridView1.Columns[1].Name = "Eye (Left)";
            dataGridView1.Columns[2].Name = "SP (Left)";
            dataGridView1.Columns[3].Name = "CP (Left)";
            dataGridView1.Columns[4].Name = "VA (Left)";
            dataGridView1.Columns[5].Name = "Axis (Left)";
            dataGridView1.Columns[6].Name = "IP (Left)";

            dataGridView1.Columns[7].Name = "Eye (Right)";
            dataGridView1.Columns[8].Name = "SP (Right)";
            dataGridView1.Columns[9].Name = "CP (Right)";
            dataGridView1.Columns[10].Name = "VA (Right)";
            dataGridView1.Columns[11].Name = "Axis (Right)";
            dataGridView1.Columns[12].Name = "IP (Right)";

            dataGridView1.Columns[13].Name = "Eye Test Date";

            dataGridView1.Columns[14].Name = "Id";
            dataGridView1.Columns[14].Visible = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Prescription";
            buttonColumn.Text = "Prescription";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle = FlatStyle.Flat;

            buttonColumn.DefaultCellStyle.BackColor = Color.FromArgb(210, 210, 210);

            dataGridView1.Columns.Add(buttonColumn);

            Helper.conn.Open();

            string query = filter ? "select (select firstname+' '+lastname from patient  where id=ET.PATIENT_ID),* from EYE_TEST ET where ET.PATIENT_ID = " + patient_id :
                "select (select firstname+' '+lastname from patient  where id=ET.PATIENT_ID),* from EYE_TEST ET";

            SqlCommand cmd = new SqlCommand(query, Helper.conn);

            string temp = "";
            string[] array;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string id = "" + dr[1];
                    string name = "" + dr[0];
                    string json = "" + dr[3];
                    string date;
                    if (dr[4] != null && !string.IsNullOrWhiteSpace(dr[4].ToString()) && dr[4].ToString().IndexOf(" ") != -1)
                        date = dr[4].ToString().Split(' ')[0];
                    else date = "" + dr[4];

                    string eye_left = "Left";
                    string sp_left = "";
                    string cp_left = "";
                    string va_left = "";
                    string axis_left = "";
                    string ip_left = "";

                    string eye_right = "Right";
                    string sp_right = "";
                    string cp_right = "";
                    string va_right = "";
                    string axis_right = "";
                    string ip_right = "";

                    if(json.ToLower().IndexOf("left") != -1)
                    {
                        //[ { "Eye": "Left", "SP": "1", "CP": "2", "VA": "34", "Axis": "4", "IP": "5" } ]
                        temp = json.Substring(json.ToLower().IndexOf("left"));
                        temp = temp.Substring(temp.IndexOf(",") + 1);
                        temp = temp.Remove(temp.IndexOf("}")).Trim();

                        array = temp.Split(',');

                        sp_left = array[0].Split(':')[1].Replace("\"", "").Trim();
                        cp_left = array[1].Split(':')[1].Replace("\"", "").Trim();
                        va_left = array[2].Split(':')[1].Replace("\"", "").Trim();
                        axis_left = array[3].Split(':')[1].Replace("\"", "").Trim();
                        ip_left = array[4].Split(':')[1].Replace("\"", "").Trim();
                    }

                    if (json.ToLower().IndexOf("right") != -1)
                    {
                        //[ { "Eye": "Right", "SP": "1", "CP": "2", "VA": "34", "Axis": "4", "IP": "5" } ]
                        temp = json.Substring(json.ToLower().IndexOf("right"));
                        temp = temp.Substring(temp.IndexOf(",") + 1);
                        temp = temp.Remove(temp.IndexOf("}")).Trim();

                        array = temp.Split(',');

                        sp_right = array[0].Split(':')[1].Replace("\"", "").Trim();
                        cp_right = array[1].Split(':')[1].Replace("\"", "").Trim();
                        va_right = array[2].Split(':')[1].Replace("\"", "").Trim();
                        axis_right = array[3].Split(':')[1].Replace("\"", "").Trim();
                        ip_right = array[4].Split(':')[1].Replace("\"", "").Trim();
                    }

                    dataGridView1.Rows.Add(name, eye_left, sp_left, cp_left, va_left, axis_left, ip_left, eye_right,sp_right,cp_right,
                                            va_right, axis_right, ip_right, date, id); 
                }
            }

            Helper.conn.Close();
        }

        public void FillEyeTestsGridViewWithFilter(int patient_id)
        {
            this.patient_id = patient_id;
            filter = true;
            FillEyeTestsGridView();
            filter = false;
        }
    }
}
