using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ARP
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "       فست فود آبتین" + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("نوع" + "\t\t\t\t" + "مقدار" + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            if (chk1.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا اسپشیال \t\t\t\t" + txt1.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk2.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا مخصوص \t\t\t\t" + txt2.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk3.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا پپرونی \t\t\t\t" + txt3.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk4.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا مرغ و قارچ \t\t\t\t" + txt4.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk5.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا گوشت و قارچ \t\t\t\t" + txt5.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk6.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا مارگریتا \t\t\t\t" + txt6.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk7.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا سیر و استیک \t\t\t\t" + txt7.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk8.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا سبزیجات \t\t\t\t" + txt8.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk9.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا چهار فصل \t\t\t\t" + txt9.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk10.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا بیکن \t\t\t\t" + txt10.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk11.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا سوسیس و قارچ \t\t\t\t" + txt11.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk12.Checked == true)
            {
                rtfReceipt.AppendText("پیتزا تندوری \t\t\t\t" + txt12.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk13.Checked == true)
            {
                rtfReceipt.AppendText("ساندویچ هات داگ \t\t\t\t" + txt13.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk14.Checked == true)
            {
                rtfReceipt.AppendText("ساندیچ زینگر \t\t\t\t" + txt14.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk15.Checked == true)
            {
                rtfReceipt.AppendText("همبرگر \t\t\t\t" + txt15.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk16.Checked == true)
            {
                rtfReceipt.AppendText("چیز برگر \t\t\t\t" + txt16.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk17.Checked == true)
            {
                rtfReceipt.AppendText("قارچ برگر \t\t\t\t" + txt17.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk18.Checked == true)
            {
                rtfReceipt.AppendText("دبل چیز برگر \t\t\t\t" + txt18.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk19.Checked == true)
            {
                rtfReceipt.AppendText("ساندویچ فیله مرغ کبابی \t\t\t\t" + txt19.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk20.Checked == true)
            {
                rtfReceipt.AppendText("ساندویچ بیگ فیلر اسپایسی \t\t\t\t" + txt20.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk21.Checked == true)
            {
                rtfReceipt.AppendText("مرغ سوخاری دو تکه \t\t\t\t" + txt21.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk22.Checked == true)
            {
                rtfReceipt.AppendText("مرغ سوخاری سه تکه \t\t\t\t" + txt22.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk23.Checked == true)
            {
                rtfReceipt.AppendText("فیله استریپس \t\t\t\t" + txt23.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk24.Checked == true)
            {
                rtfReceipt.AppendText("سیب زمینی \t\t\t\t" + txt24.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk25.Checked == true)
            {
                rtfReceipt.AppendText("نوشابه \t\t\t\t" + txt28.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk26.Checked == true)
            {
                rtfReceipt.AppendText("دلستر \t\t\t\t" + txt29.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk27.Checked == true)
            {
                rtfReceipt.AppendText("دوغ \t\t\t\t" + txt30.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chk28.Checked == true)
            {
                rtfReceipt.AppendText("آب \t\t\t\t" + txt31.Text + Environment.NewLine);
            }
            else
            {

            }





            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("مالیات \t\t\t\t" + txt25.Text + Environment.NewLine);
            rtfReceipt.AppendText("قیمت کل \t\t\t" + txt26.Text + Environment.NewLine);
            rtfReceipt.AppendText("قابل پرداخت \t\t\t" + txt27.Text + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);

        }



        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                txt1.Enabled = true;
                txt1.Text = "1";
            }
            else
            {
                txt1.Enabled = false;
                txt1.Text = "0";
            }

        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == true)
            {
                txt2.Enabled = true;
                txt2.Text = "1";
            }
            else
            {
                txt2.Enabled = false;
                txt2.Text = "0";
            }

        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == true)
            {
                txt3.Enabled = true;
                txt3.Text = "1";
            }
            else
            {
                txt3.Enabled = false;
                txt3.Text = "0";
            }

        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == true)
            {
                txt4.Enabled = true;
                txt4.Text = "1";
            }
            else
            {
                txt4.Enabled = false;
                txt4.Text = "0";
            }

        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == true)
            {
                txt5.Enabled = true;
                txt5.Text = "1";
            }
            else
            {
                txt5.Enabled = false;
                txt5.Text = "0";
            }

        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6.Checked == true)
            {
                txt6.Enabled = true;
                txt6.Text = "1";
            }
            else
            {
                txt6.Enabled = false;
                txt6.Text = "0";
            }

        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7.Checked == true)
            {
                txt7.Enabled = true;
                txt7.Text = "1";
            }
            else
            {
                txt7.Enabled = false;
                txt7.Text = "0";
            }

        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8.Checked == true)
            {
                txt8.Enabled = true;
                txt8.Text = "1";
            }
            else
            {
                txt8.Enabled = false;
                txt8.Text = "0";
            }

        }

        private void chk9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk9.Checked == true)
            {
                txt9.Enabled = true;
                txt9.Text = "1";
            }
            else
            {
                txt9.Enabled = false;
                txt9.Text = "0";
            }

        }

        private void chk10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk10.Checked == true)
            {
                txt10.Enabled = true;
                txt10.Text = "1";
            }
            else
            {
                txt10.Enabled = false;
                txt10.Text = "0";
            }

        }

        private void chk11_CheckedChanged(object sender, EventArgs e)
        {
            if (chk11.Checked == true)
            {
                txt11.Enabled = true;
                txt11.Text = "1";
            }
            else
            {
                txt11.Enabled = false;
                txt11.Text = "0";
            }

        }

        private void chk12_CheckedChanged(object sender, EventArgs e)
        {
            if (chk12.Checked == true)
            {
                txt12.Enabled = true;
                txt12.Text = "1";
            }
            else
            {
                txt12.Enabled = false;
                txt12.Text = "0";
            }

        }

        private void chk13_CheckedChanged(object sender, EventArgs e)
        {
            if (chk13.Checked == true)
            {
                txt13.Enabled = true;
                txt13.Text = "1";
            }
            else
            {
                txt13.Enabled = false;
                txt13.Text = "0";
            }

        }

        private void chk14_CheckedChanged(object sender, EventArgs e)
        {
            if (chk14.Checked == true)
            {
                txt14.Enabled = true;
                txt14.Text = "1";
            }
            else
            {
                txt14.Enabled = false;
                txt14.Text = "0";
            }

        }

        private void chk15_CheckedChanged(object sender, EventArgs e)
        {
            if (chk15.Checked == true)
            {
                txt15.Enabled = true;
                txt15.Text = "1";
            }
            else
            {
                txt15.Enabled = false;
                txt15.Text = "0";
            }

        }

        private void chk16_CheckedChanged(object sender, EventArgs e)
        {
            if (chk16.Checked == true)
            {
                txt16.Enabled = true;
                txt16.Text = "1";
            }
            else
            {
                txt16.Enabled = false;
                txt16.Text = "0";
            }

        }

        private void chk17_CheckedChanged(object sender, EventArgs e)
        {
            if (chk17.Checked == true)
            {
                txt17.Enabled = true;
                txt17.Text = "1";
            }
            else
            {
                txt17.Enabled = false;
                txt17.Text = "0";
            }

        }

        private void chk18_CheckedChanged(object sender, EventArgs e)
        {
            if (chk18.Checked == true)
            {
                txt18.Enabled = true;
                txt18.Text = "1";
            }
            else
            {
                txt18.Enabled = false;
                txt18.Text = "0";
            }

        }

        private void chk19_CheckedChanged(object sender, EventArgs e)
        {
            if (chk19.Checked == true)
            {
                txt19.Enabled = true;
                txt19.Text = "1";
            }
            else
            {
                txt19.Enabled = false;
                txt19.Text = "0";
            }

        }

        private void chk20_CheckedChanged(object sender, EventArgs e)
        {
            if (chk20.Checked == true)
            {
                txt20.Enabled = true;
                txt20.Text = "1";
            }
            else
            {
                txt20.Enabled = false;
                txt20.Text = "0";
            }

        }

        private void chk21_CheckedChanged(object sender, EventArgs e)
        {
            if (chk21.Checked == true)
            {
                txt21.Enabled = true;
                txt21.Text = "1";
            }
            else
            {
                txt21.Enabled = false;
                txt21.Text = "0";
            }

        }

        private void chk22_CheckedChanged(object sender, EventArgs e)
        {
            if (chk22.Checked == true)
            {
                txt22.Enabled = true;
                txt22.Text = "1";
            }
            else
            {
                txt22.Enabled = false;
                txt22.Text = "0";
            }

        }

        private void chk23_CheckedChanged(object sender, EventArgs e)
        {
            if (chk23.Checked == true)
            {
                txt23.Enabled = true;
                txt23.Text = "1";
            }
            else
            {
                txt23.Enabled = false;
                txt23.Text = "0";
            }

        }

        private void chk24_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24.Checked == true)
            {
                txt24.Enabled = true;
                txt24.Text = "1";
            }
            else
            {
                txt24.Enabled = false;
                txt24.Text = "0";
            }

        }

        private void chk25_CheckedChanged(object sender, EventArgs e)
        {
            if (chk25.Checked == true)
            {
                txt28.Enabled = true;
                txt28.Text = "1";
            }
            else
            {
                txt28.Enabled = false;
                txt28.Text = "0";
            }

        }

        private void chk26_CheckedChanged(object sender, EventArgs e)
        {
            if (chk26.Checked == true)
            {
                txt29.Enabled = true;
                txt29.Text = "1";
            }
            else
            {
                txt29.Enabled = false;
                txt29.Text = "0";
            }

        }

        private void chk27_CheckedChanged(object sender, EventArgs e)
        {
            if (chk27.Checked == true)
            {
                txt30.Enabled = true;
                txt30.Text = "1";
            }
            else
            {
                txt30.Enabled = false;
                txt30.Text = "0";
            }

        }
        private void chk28_CheckedChanged(object sender, EventArgs e)
        {
            if (chk28.Checked == true)
            {
                txt31.Enabled = true;
                txt31.Text = "1";
            }
            else
            {
                txt31.Enabled = false;
                txt31.Text = "0";
            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txt4.Text = "0";
            txt5.Text = "0";
            txt6.Text = "0";
            txt7.Text = "0";
            txt8.Text = "0";
            txt9.Text = "0";
            txt10.Text = "0";
            txt11.Text = "0";
            txt12.Text = "0";
            txt13.Text = "0";
            txt14.Text = "0";
            txt15.Text = "0";
            txt16.Text = "0";
            txt17.Text = "0";
            txt18.Text = "0";
            txt19.Text = "0";
            txt20.Text = "0";
            txt21.Text = "0";
            txt22.Text = "0";
            txt23.Text = "0";
            txt24.Text = "0";
            txt25.Text = "0";
            txt26.Text = "0";
            txt27.Text = "0";
            txt28.Text = "0";
            txt29.Text = "0";
            txt30.Text = "0";
            txt31.Text = "0";





            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false;
            chk7.Checked = false;
            chk8.Checked = false;
            chk9.Checked = false;
            chk10.Checked = false;
            chk11.Checked = false;
            chk12.Checked = false;
            chk13.Checked = false;
            chk14.Checked = false;
            chk15.Checked = false;
            chk16.Checked = false;
            chk17.Checked = false;
            chk18.Checked = false;
            chk19.Checked = false;
            chk20.Checked = false;
            chk21.Checked = false;
            chk22.Checked = false;
            chk23.Checked = false;
            chk24.Checked = false;
            chk25.Checked = false;
            chk26.Checked = false;
            chk27.Checked = false;
            chk28.Checked = false;



        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("آیا میخواهید خارج شوید؟", "Abtin Restaurant Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, n1, n2, n3, n4;
            p1 = 185.000; p2 = 185.000; p3 = 165.000; p4 = 183.000; p5 = 180.000; p6 = 118.000; p7 = 220.000; p8 = 145.000; p9 = 185.000;
            p10 = 158.000; p11 = 175.000; p12 = 175.000; s1 = 88.000; s2 = 128.000; s3 = 148.000; s4 = 162.000; s5 = 165.000; s6 = 122.000;
            s7 = 125.000; s8 = 120.000; s9 = 155.000; s10 = 182.000; s11 = 180.000; s12 = 59.000; n1 = 11.000; n2 = 13.000; n3 = 10.000; n4 = 5.000;
            

            double ss1 = Convert.ToDouble(txt13.Text);
            double ss2 = Convert.ToDouble(txt14.Text);
            double ss3 = Convert.ToDouble(txt15.Text);
            double ss4 = Convert.ToDouble(txt16.Text);
            double ss5 = Convert.ToDouble(txt17.Text);
            double ss6 = Convert.ToDouble(txt18.Text);
            double ss7 = Convert.ToDouble(txt19.Text);
            double ss8 = Convert.ToDouble(txt20.Text);
            double ss9 = Convert.ToDouble(txt21.Text);
            double ss10 = Convert.ToDouble(txt22.Text);
            double ss11 = Convert.ToDouble(txt23.Text);
            double ss12 = Convert.ToDouble(txt24.Text);
            double pp1 = Convert.ToDouble(txt1.Text);
            double pp2 = Convert.ToDouble(txt2.Text);
            double pp3 = Convert.ToDouble(txt3.Text);
            double pp4 = Convert.ToDouble(txt4.Text);
            double pp5 = Convert.ToDouble(txt5.Text);
            double pp6 = Convert.ToDouble(txt6.Text);
            double pp7 = Convert.ToDouble(txt7.Text);
            double pp8 = Convert.ToDouble(txt8.Text);
            double pp9 = Convert.ToDouble(txt9.Text);
            double pp10 = Convert.ToDouble(txt10.Text);
            double pp11 = Convert.ToDouble(txt11.Text);
            double pp12 = Convert.ToDouble(txt12.Text);
            double nn1 = Convert.ToDouble(txt28.Text);
            double nn2 = Convert.ToDouble(txt29.Text);
            double nn3 = Convert.ToDouble(txt30.Text);
            double nn4 = Convert.ToDouble(txt31.Text);





            double total = (ss1 * s1) + (ss2 * s2) + (ss3 * s3) + (ss4 * s1) + (ss5 * s5) + (ss6 * s6) + (ss7 * s7) + (ss8 * s8) + (ss9 * s9) +
                (ss10 * s10) + (ss11 * s11) + (ss12 * s12) + (pp1 * p1) + (pp2 * p2) + (pp3 * p3) + (pp4 * p4) + (pp5 * p5) + (pp6 * p6) +
                (pp7 * p7) + (pp8 * p8) + (pp9 * p9) + (pp10 * p10) + (pp11 * p11) + (pp12 * p12) + (nn1 * n1) + (nn2 * n2) + (nn3 * n3) + (nn4 * n4);
            txt26.Text = Convert.ToString(total);


            double tax = (total * 9) / 100;
            txt25.Text = Convert.ToString(tax);


            double toootal = total + tax;
            txt27.Text = Convert.ToString(toootal);



        }

        private void frm1_Load(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txt4.Text = "0";
            txt5.Text = "0";
            txt6.Text = "0";
            txt7.Text = "0";
            txt8.Text = "0";
            txt9.Text = "0";
            txt10.Text = "0";
            txt11.Text = "0";
            txt12.Text = "0";
            txt13.Text = "0";
            txt14.Text = "0";
            txt15.Text = "0";
            txt16.Text = "0";
            txt17.Text = "0";
            txt18.Text = "0";
            txt19.Text = "0";
            txt20.Text = "0";
            txt21.Text = "0";
            txt22.Text = "0";
            txt23.Text = "0";
            txt24.Text = "0";
            txt25.Text = "0";
            txt26.Text = "0";
            txt27.Text = "0";
            txt28.Text = "0";
            txt29.Text = "0";
            txt30.Text = "0";
            txt31.Text = "0";


        }
    }
}
