using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Assist
{
    public partial class Math_Assist : Form
    {
        public Math_Assist()
        {
            InitializeComponent();
        }

        private void btn_Distance_Click(object sender, EventArgs e)
        {
            double diff_X = Convert.ToDouble(txtbox_X2.Text) - Convert.ToDouble(txtbox_X1.Text);
            double diff_Y = Convert.ToDouble(txtbox_Y2.Text) - Convert.ToDouble(txtbox_Y1.Text);
            double distance = Math.Round(Math.Sqrt((diff_X * diff_X) + (diff_Y * diff_Y)), 3);
            lbl_Distance.Text = "Distance: " + Convert.ToString(distance);
        }

        private void btn_Midpoint_Click(object sender, EventArgs e)
        {
            double X1 = Convert.ToDouble(txtbox_X1.Text);
            double Y1 = Convert.ToDouble(txtbox_Y1.Text);
            double X2 = Convert.ToDouble(txtbox_X2.Text);
            double Y2 = Convert.ToDouble(txtbox_Y2.Text);
            double XM = (X1 + X2) / 2;
            double YM = (Y1 + Y2) / 2;
            lbl_Midpoint.Text = Convert.ToString(Math.Round(XM, 2)) + ", " + Convert.ToString(Math.Round(YM, 2));
        }

        private void btn_Endpoint_1_Click(object sender, EventArgs e)
        {
            double X2 = Convert.ToDouble(txtbox_X2.Text);
            double Y2 = Convert.ToDouble(txtbox_Y2.Text);
            double XM = Convert.ToDouble(txtbox_XM.Text);
            double YM = Convert.ToDouble(txtbox_YM.Text);
            double X1 = (2 * XM) - X2;
            double Y1 = (2 * YM) - Y2;
            lbl_Endpoint_1.Text = X1 + ", " + Y1;
        }

        private void btn_Endpoint_2_Click(object sender, EventArgs e)
        {
            double X1 = Convert.ToDouble(txtbox_X1.Text);
            double Y1 = Convert.ToDouble(txtbox_Y1.Text);
            double XM = Convert.ToDouble(txtbox_XM.Text);
            double YM = Convert.ToDouble(txtbox_YM.Text);
            double X2 = (2 * XM) - X1;
            double Y2 = (2 * YM) - Y1;
            lbl_Endpoint_2.Text = X2 + ", " + Y2;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Math Assist V0.1, Created by Caleb E. Grebill - 2/10/2021");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Endpoint_1.Text = "";
            lbl_Midpoint.Text = "";
            lbl_Endpoint_2.Text = "";
            lbl_Distance.Text = "";
            txtbox_X1.Text = "";
            txtbox_X2.Text = "";
            txtbox_XM.Text = "";
            txtbox_Y1.Text = "";
            txtbox_Y2.Text = "";
            txtbox_YM.Text = "";
        }
    }
}
