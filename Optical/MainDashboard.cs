using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optical
{
    public partial class MainDashboard : Form
    {
        //Smoothening Form's Behaviour and Animation
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        //Define User Controls Variables
        PatientsUserControl patientsUserControl = new PatientsUserControl();
        EyeTestUserControl eyeTestUserControl = new EyeTestUserControl();
        Dashboard dashboardUserControl = new Dashboard();
        Control temp = null;
        public MainDashboard()
        {
            InitializeComponent();
            //Setting images to PictureBoxses
            Bitmap home = new Bitmap(Image.FromFile(@"resources\icons\home.png"));
            pictureBoxHome.Image = home;
            Bitmap person = new Bitmap(Image.FromFile(@"resources\icons\person.png"));
            pictureBoxPerson.Image = person;
            Bitmap eye = new Bitmap(Image.FromFile(@"resources\icons\eye.png"));
            pictureBoxEye.Image = eye;
            Bitmap patientsReports = new Bitmap(Image.FromFile(@"resources\icons\reports.png"));
            pictureBoxPatientsReports.Image = patientsReports;
            Bitmap eyeTestReports = new Bitmap(Image.FromFile(@"resources\icons\reports.png"));
            pictureBoxEyeTestReports.Image = eyeTestReports;
            Bitmap logout = new Bitmap(Image.FromFile(@"resources\icons\logout.png"));
            pictureBoxLogout.Image = logout;
            Bitmap close = new Bitmap(Image.FromFile(@"resources\icons\close.png"));
            pictureBoxClose.Image = close;
            Bitmap minimize = new Bitmap(Image.FromFile(@"resources\icons\minimize.png"));
            pictureBoxMinimize.Image = minimize;

            pictureBoxClose.Click += (s, e) =>
            {
                this.Close();
            };

            pictureBoxMinimize.Click += (s, e) =>
            {
                this.WindowState = FormWindowState.Minimized;
            };

            //Maximize the Form
            this.WindowState = FormWindowState.Maximized;

            //Initialize Menu
            this.Shown += (s, e) =>
            {
                dashboardUserControl.Size = container.Size;
                container.Controls.Add(dashboardUserControl);
                temp = controlDashboard;
                temp.BackColor = Color.DodgerBlue;
                foreach (Control child in temp.Controls)
                {
                    if (child is Label)
                    {
                        child.ForeColor = Color.White;
                    }
                };
            };

            //Add Click Event to the Menu Item and its Children Controls
            controlPatientManagement.AddAction(new Action(() =>
            {
                container.Controls.Clear();
                patientsUserControl.Size = container.Size;
                container.Controls.Add(patientsUserControl);
                RenderMenu(temp);
                temp = controlPatientManagement;
                temp.BackColor = Color.DodgerBlue;
                foreach (Control child in temp.Controls)
                {
                    if (child is Label)
                    {
                        child.ForeColor = Color.White;
                    }
                };
            }));

            controlEyeTestManagement.AddAction(() =>
            {
                container.Controls.Clear();
                eyeTestUserControl.Size = container.Size;
                container.Controls.Add(eyeTestUserControl);
                RenderMenu(temp);
                temp = controlEyeTestManagement;
                temp.BackColor = Color.DodgerBlue;
                foreach (Control child in temp.Controls)
                {
                    if (child is Label)
                    {
                        child.ForeColor = Color.White;
                    }
                };
            });

            controlDashboard.AddAction(() =>
            {
                dashboardUserControl.GetData();
                container.Controls.Clear();
                dashboardUserControl.Size = container.Size;
                container.Controls.Add(dashboardUserControl);
                RenderMenu(temp);
                temp = controlDashboard;
                temp.BackColor = Color.DodgerBlue;
                foreach (Control child in temp.Controls)
                {
                    if (child is Label)
                    {
                        child.ForeColor = Color.White;
                    }
                };
            });

            controlPatientsReport.AddAction(() =>
            {
                new PatientsReport().ShowDialog();
            });

            controlEyeTestReport.AddAction(() =>
            {
                new EyeTestReport().ShowDialog();
            });

            controlDisconnect.AddAction(() =>
            {
                this.Close();
            });

            //Setting Closing Event to Dashboard, to close the Application
            this.FormClosed += (s, e) =>
            {
                Application.Exit();
            };
        }

        public void RenderMenu(Control con)
        {
            if (con != null)
            {
                con.BackColor = Color.FromArgb(195, 195, 195);
                foreach (Control child in con.Controls)
                {
                    if (child is Label)
                    {
                        child.ForeColor = Color.FromArgb(70, 70, 70);
                    }
                };
            }
        }

        public void FillPatientsGridView()
        {
            patientsUserControl.FillPatientsGridView();
        }

        public void FillEyeTestsGridView()
        {
            eyeTestUserControl.FillEyeTestsGridView();
        }

        public void FillEyeTestsGridViewWithFilter(int patient_id)
        {
            eyeTestUserControl.FillEyeTestsGridViewWithFilter(patient_id);
        }
    }
}
