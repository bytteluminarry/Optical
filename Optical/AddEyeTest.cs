using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Optical
{
    public partial class AddEyeTest : Form
    {
        public AddEyeTest()
        {
            InitializeComponent();
            //Setting Custom Styles to the Data Grid View
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ddd");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            //Filling Which Eye Combobox with Items
            foreach (string item in new string[] { "Left", "Right" })
            {
                comboBoxEye.Items.Add(item);
            }

            GetPatients();

            //Setting CLick Event to View Information Button
            buttonViewInformation.Click += (s, e) =>
            {
                if (comboBoxPatient.SelectedValue == null)
                {
                    MessageBox.Show("Select a patient!");
                    return;
                }

                Helper.conn.Open();

                SqlCommand cmd = new SqlCommand("select * from patient where id = " + comboBoxPatient.SelectedValue, Helper.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //Fetch the Selection Result
                    dr.Read();
                    string id = "" + dr[0];
                    string title = "" + dr[1];
                    string name = dr[2] + " " + dr[3];
                    string address = "" + dr[4];
                    string telephone = "" + dr[5];
                    string email = "" + dr[6];
                    string date_of_birth = "" + dr[7];
                    string age = "" + dr[8];
                    string nhs_patient = "" + dr[9];

                    string message = "ID: " + id + "\n\n" +
                                     "Title: " + title + "\n\n" +
                                     "Name: " + name + "\n\n" +
                                     "Address: " + address + "\n\n" +
                                     "Telephone: " + telephone + "\n\n" +
                                     "Email: " + email + "\n\n" +
                                     "Date of Birth: " + date_of_birth + "\n\n" +
                                     "Age: " + age + "\n\n" +
                                     "NHS Patient: " + nhs_patient;
                    MessageBox.Show(message, "Patient Information");
                }

                Helper.conn.Close();
            };

            //Setting CLick Event to Add Eye Test Button
            buttonAddEyeTest.Click += (s, e) =>
            {
                if (comboBoxEye.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(textBoxSphericalPower.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCylinderPower.Text) ||
                    string.IsNullOrWhiteSpace(textBoxVisualAcuity.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAxis.Text) ||
                    string.IsNullOrWhiteSpace(textBoxIntraocularPressure.Text))
                {
                    MessageBox.Show("All fields are required!");
                    return;
                }

                string which_eye = comboBoxEye.Text;
                string sp = textBoxSphericalPower.Text;
                string cp = textBoxCylinderPower.Text;
                string va = textBoxVisualAcuity.Text;
                string axis = textBoxAxis.Text;
                string ip = textBoxIntraocularPressure.Text;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string which_eye_column = row.Cells[0].Value.ToString();
                        if (which_eye.ToLower().Trim() == which_eye_column.ToLower().Trim())
                        {
                            MessageBox.Show("(" + which_eye_column + ") eye data already exist!");
                            return;
                        }
                    }
                }

                dataGridView1.Rows.Add(which_eye, sp, cp, va, axis, ip);
            };

            //Setting Click Event for Create Button
            buttonCreate.Click += (s, e) =>
            {
                if (comboBoxPatient.SelectedItem == null ||
                    dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("You should insert data!");
                    return;
                }

                //Generate JSON from Data Grid View to store it in the Database Table as a String JSON Field
                StringBuilder json = new StringBuilder();
                json.Append("[\n");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        json.Append("{\n");
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            string columnName = dataGridView1.Columns[i].HeaderText;
                            string columnValue = row.Cells[i].Value.ToString();

                            json.Append($"\"{columnName}\": \"{columnValue}\"");
                            if (i < dataGridView1.Columns.Count - 1)
                            {
                                json.Append(",");
                            }
                            json.Append("\n");
                        }
                        json.Append("}");
                        if (row.Index < dataGridView1.Rows.Count - 2)
                        {
                            json.Append(",");
                        }
                        json.Append("\n");
                    }
                }

                json.Append("]");

                int patient_id = Convert.ToInt32(comboBoxPatient.SelectedValue.ToString());

                Helper.conn.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO EYE_TEST (PATIENT_ID, JSON_DATA, EYE_TEST_DATE)
                                                VALUES (@patient_id, @json_data, @date);
                                                SELECT SCOPE_IDENTITY();", Helper.conn);
                cmd.Parameters.AddWithValue("@patient_id", patient_id);
                cmd.Parameters.AddWithValue("@json_data", json.ToString());
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                int eyeTestId = Convert.ToInt32(cmd.ExecuteScalar());

                Helper.conn.Close();

                Application.OpenForms.OfType<MainDashboard>().FirstOrDefault().FillEyeTestsGridView();

                new EyeTestProcess(this, eyeTestId).ShowDialog();
            };
        }

        public void GetPatients()
        {
            Helper.conn.Open();

            //Select all Patients
            SqlCommand cmd = new SqlCommand("select id,title + ' ' + firstname + ' ' + lastname as 'fullname' from patient", Helper.conn);

            //Create a Data Adapter for the Sql Command
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //Create a Table
            DataTable dt = new DataTable();

            //Fill the Table with Patient's Data
            adapter.Fill(dt);

            //Fill in the Combobox with Patient's Names, and specify Id Values for each Patient
            comboBoxPatient.DataSource = dt;
            comboBoxPatient.ValueMember = "id";
            comboBoxPatient.DisplayMember = "fullname";

            Helper.conn.Close();
        }
    }
}
