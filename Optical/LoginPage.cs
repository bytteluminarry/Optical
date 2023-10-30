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
using static System.Net.Mime.MediaTypeNames;

namespace Optical
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            //Setting Click Event to Login Button
            buttonLogin.Click += (s, e) =>
            {
                //Get Username and Password from textbox fields
                string username = textBoxUsername.Text.ToLower().Trim();
                string password = textBoxPassword.Text;

                //Open SQL Connection from the static 'Helper' Class
                Helper.conn.Open();

                //Create a command to SQL, to select the database user that matches the given username and password 
                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE LOWER(LTRIM(RTRIM(username))) = @user and PASSWORD = @pass", Helper.conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                //Fetch results
                SqlDataReader dr = cmd.ExecuteReader();

                //If the username and password are correct
                if (dr.HasRows)
                {
                    Helper.conn.Close();

                    //Open MainForm
                    MainDashboard dashboard = new MainDashboard();
                    dashboard.Show();
                    System.Windows.Forms.Application.OpenForms.OfType<MainPage>().FirstOrDefault().Hide();
                    this.Close();
                }
                else
                {
                    //The SqlDataReader Object did not receive any value from the database,
                    //because the user did not input a correct username and password
                    MessageBox.Show("Either the username or the password is incorrect!");
                }

                //Close the SQL Connection from the static 'Helper' Class
                Helper.conn.Close();
            };
        }
    }
}
