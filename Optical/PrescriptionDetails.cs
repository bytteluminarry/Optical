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
    public partial class PrescriptionDetails : Form
    {
        public PrescriptionDetails(int eye_test_id)
        {
            InitializeComponent();
            Helper.conn.Open();

            SqlCommand cmd = new SqlCommand("select * from PATIENT where ID in (select PATIENT_ID from EYE_TEST where ID = " + eye_test_id + ")", Helper.conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string name = dr[1] + " " + dr[2] + " " + dr[3];
                labelPatient.Text = name;

                int id = Convert.ToInt32(dr[0].ToString());

                //Setting Click Event to Details Button
                buttonDetails.Click += (s, e) =>
                {
                    ShowDetails(id);
                };
            }

            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("select * from PRESCRIPTION where EYE_TEST_ID =" + eye_test_id, Helper.conn);

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string lens_type = "" + dr[2];
                string notes = "" + dr[3];

                labelLensType.Text = lens_type;
                labelNotes.Text = notes;
            }

            Helper.conn.Close();
        }

        public void ShowDetails(int id)
        {
            Helper.conn.Open();

            SqlCommand cmd = new SqlCommand("select * from patient where id = " + id, Helper.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                //Fetch the Selection Result
                dr.Read();
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
        }
    }
}
