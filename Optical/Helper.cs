using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace Optical
{
    internal static class Helper
    {
        //Create an instance from SqlConnection
        public static SqlConnection conn =
            new SqlConnection(@"Data Source=DESKTOP-V5MAH75;Initial Catalog=NEA;Integrated Security=True");

        //Create a function to add Click Events on a specific Control and its Children Controls
        public static void AddAction(this Control control, Action action)
        {
            control.Click += (s, e) =>
            {
                action.Invoke();
            };
            foreach (Control con in control.Controls)
            {
                con.Click += (s, e) =>
                {
                    action.Invoke();
                };
            }
        }
    }
}