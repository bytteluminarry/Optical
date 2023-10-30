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
    public partial class EyeTestProcess : Form
    {
        public EyeTestProcess(Form parent, int eyeTestId)
        {
            InitializeComponent();
            //Setting Gif Image to Picture Box
            pictureBoxProcess.ImageLocation = @"resources\gif\process.gif";

            //Setting Click Event to Proceed Button
            buttonProceed.Click += (s, e) =>
            {
                new Prescription(this, eyeTestId).ShowDialog();
            };

            //Close this Form's Parent on Close Event
            this.FormClosed += (s, e) =>
            {
                parent.Close();
            };
        }
    }
}
