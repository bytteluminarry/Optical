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

namespace Optical
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            GetData();

            this.SizeChanged += (s, e) =>
            {
                dashboardContainer.Left = (panel1.Width - dashboardContainer.Width) / 2;
                dashboardContainer.Top = (panel1.Height - dashboardContainer.Height) / 2;
            };
        }

        public void GetData()
        {
            Helper.conn.Open();

            string patients_records_count = new SqlCommand("select count(*) from PATIENT", Helper.conn).ExecuteScalar().ToString();
            labelPatientRecordsValue.Text = patients_records_count;
            labelPatientRecordsKey.Left = labelPatientRecordsValue.Width + labelPatientRecordsValue.Left - 10;

            string patients_history_count = new SqlCommand("select count(*) from PATIENT_HISTORY", Helper.conn).ExecuteScalar().ToString();
            labelPatientsHistoryValue.Text = patients_history_count;
            labelPatientsHistoryKey.Left = labelPatientsHistoryValue.Width + labelPatientsHistoryValue.Left - 10;

            string eye_tests_count = new SqlCommand("select count(*) from EYE_TEST", Helper.conn).ExecuteScalar().ToString();
            labelEyeTestRecordsValue.Text = eye_tests_count;
            labelEyeTestRecordsKey.Left = labelEyeTestRecordsValue.Width + labelEyeTestRecordsValue.Left - 10;

            string prescriptions_count = new SqlCommand("select count(*) from PRESCRIPTION", Helper.conn).ExecuteScalar().ToString();
            labelPrescriptionsValue.Text = prescriptions_count;
            labelPrescriptionsKey.Left = labelPrescriptionsValue.Width + labelPrescriptionsValue.Left - 10;

            string users_count = new SqlCommand("select count(*) from Users", Helper.conn).ExecuteScalar().ToString();
            labelUsersValue.Text = users_count;
            labelUsersKey.Left = labelUsersValue.Width + labelUsersValue.Left - 10;

            Helper.conn.Close();
        }
    }
}
