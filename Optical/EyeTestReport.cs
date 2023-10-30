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
    public partial class EyeTestReport : Form
    {
        public EyeTestReport()
        {
            InitializeComponent();
            Helper.conn.Open();

            SqlCommand cmd = new SqlCommand("select top(30) * from patient p inner join EYE_TEST et on p.id = et.patient_id order by et.EYE_TEST_DATE desc", Helper.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Helper.conn.Close();

            chart1.Series.Clear();

            chart1.Series.Add("EyeTest");

            chart1.Series["EyeTest"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            int c = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                int patientID = Convert.ToInt32(row["id"]);
                DateTime dateValue = Convert.ToDateTime(row["EYE_TEST_DATE"]);

                chart1.Series["EyeTest"].Points.AddXY(c, dateValue);

                c++;
            }
        }
    }
}
