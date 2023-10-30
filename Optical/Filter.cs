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
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
            GetPatients();

            //Setting Click Event to Apply Button
            buttonApplyFilter.Click += (s, e) =>
            {
                if (comboBoxPatients.SelectedItem == null)
                {
                    MessageBox.Show("You should choose a patient!");
                    return;
                }

                int id = Convert.ToInt32(comboBoxPatients.SelectedValue);
                Application.OpenForms.OfType<MainDashboard>().FirstOrDefault().FillEyeTestsGridViewWithFilter(id);

                this.Close();
            };

            //Setting Click Event to Reset Button
            buttonResetFilter.Click += (s, e) =>
            {
                Application.OpenForms.OfType<MainDashboard>().FirstOrDefault().FillEyeTestsGridView();
                this.Close();
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
            comboBoxPatients.DataSource = dt;
            comboBoxPatients.ValueMember = "id";
            comboBoxPatients.DisplayMember = "fullname";

            Helper.conn.Close();
        }
    }
}
