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
    public partial class Prescription : Form
    {
        public Prescription(Form parent, int eyeTestId)
        {
            InitializeComponent();
            //Filling Combobox with Items
            foreach (string item in new string[] { "Single Vision Lenses", "Bifocal Lenses", "Progressive Lenses", "Reading Glasses",
                                                    "Computer Glasses", "Photochromic Lenses"})
            {
                comboBoxLensType.Items.Add(item);
            }

            //Setting Click Event to Confirm Button
            buttonConfirm.Click += (s, e) =>
            {
                if (comboBoxLensType.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(richTextBoxPrescription.Text))
                {
                    MessageBox.Show("All fields are required!");
                    return;
                }

                int patient_id = Convert.ToInt32(comboBoxLensType.SelectedValue);
                string lens_type = comboBoxLensType.Text;
                string prescription = richTextBoxPrescription.Text;

                Helper.conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO PRESCRIPTION (EYE_TEST_ID, LENS_TYPE, NOTES) VALUES (@id, @lens_type, @notes)", Helper.conn);
                cmd.Parameters.AddWithValue("@id", eyeTestId);
                cmd.Parameters.AddWithValue("@lens_type", lens_type);
                cmd.Parameters.AddWithValue("@notes", prescription);

                cmd.ExecuteNonQuery();

                Helper.conn.Close();

                MessageBox.Show("Added Successfully!");

                this.Close();
            };

            //Close this Form's Parent on Close Event
            this.FormClosed += (s, e) =>
            {
                parent.Close();
            };
        }
    }
}
