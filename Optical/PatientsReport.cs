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
    public partial class PatientsReport : Form
    {
        public PatientsReport()
        {
            InitializeComponent();
            Helper.conn.Open();

            SqlCommand cmd = new SqlCommand("select top(30) * from patient p inner join PATIENT_HISTORY ph on p.id = ph.patient_id order by APPOINTMENT_DATE desc", Helper.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Helper.conn.Close();

            chart1.Series.Clear();

            chart1.Series.Add("PatientHistory");

            chart1.Series["PatientHistory"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            int c = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                int patientID = Convert.ToInt32(row["id"]);
                DateTime dateValue = Convert.ToDateTime(row["APPOINTMENT_DATE"]);
                string patientName = row["TITLE"] + " " + row["FIRSTNAME"] + " " + row["LASTNAME"];

                chart1.Series["PatientHistory"].Points.AddXY(c, dateValue);

                c++;
            }
        }
    }
}
