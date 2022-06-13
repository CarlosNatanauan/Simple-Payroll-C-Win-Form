using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsTP
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        
        public Form1()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.fullname = tbLname.Text + ", " + tbFname.Text;
            //to hide some numbers
            string piConv = Regex.Replace(tbPI.Text, "[0-9]{2,}", "*");
            string phConv = Regex.Replace(tbPH.Text, "[0-9]{2,}", "*");
            string ssConv = Regex.Replace(tbSS.Text, "[0-9]{2,}", "*");
            form.piNum = piConv;
            form.phNum = phConv;
            form.ssNum = ssConv;

            double dr = Convert.ToDouble(tbDR.Text);
            double dw = Convert.ToDouble(tbDW.Text);
            double hw = Convert.ToDouble(tbHW.Text);
            double gPay = (dr*dw)+(dr*hw);
            double nPay = gPay-((0.01+0.0275+0.1)*gPay);
            form.dailyrate = dr;
            form.dayswork = dw;
            form.holidaywork = hw;
            form.grosspay = gPay;
            form.netpay = nPay;

            form.Show();
            this.Visible = false;
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbSS.Text = String.Empty;
            tbPH.Text = String.Empty;
            tbPI.Text = String.Empty;
            tbDR.Text = String.Empty;
            tbHW.Text = String.Empty;
            tbDW.Text = String.Empty;
        }

        private void clear_MouseEnter(object sender, EventArgs e)
        {
            clear.BackColor = Color.DarkOrange;
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = Color.White;
        }




        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void tbHW_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCompute_MouseEnter(object sender, EventArgs e)
        {
            btCompute.BackColor = Color.DarkOrange;
        }


        private void btCompute_MouseLeave(object sender, EventArgs e)
        {
            btCompute.BackColor = Color.White;
        }

        

        
    }
}
