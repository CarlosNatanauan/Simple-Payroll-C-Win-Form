using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsTP
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public string fullname { get; set; }
        public string phNum { get; set; }
        public string ssNum { get; set; }
        public string piNum { get; set; }
        public double dailyrate { get; set; }
        public double dayswork { get; set; }
        public double holidaywork { get; set; }
        public double grosspay { get; set; }
        public double netpay { get; set; }
        public string date { get; set; }
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            lbName.Text = fullname;
            lbPI.Text = piNum;
            lbSS.Text = ssNum;
            lbPH.Text = phNum;

            lbDW.Text = dayswork.ToString();
            lbHW.Text = holidaywork.ToString();
            lbDR.Text = "₱" + dailyrate.ToString();
            lbGP.Text = "₱" + grosspay.ToString();
            lbNP.Text = "₱" + netpay.ToString();
            tbDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;
        }

        

        private void lbName_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void btEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEx_MouseEnter(object sender, EventArgs e)
        {
            btEx.BackColor = Color.DarkOrange;
        }

        private void btEx_MouseLeave(object sender, EventArgs e)
        {
            btEx.BackColor = Color.White;
        }

        private void btReturn_MouseEnter(object sender, EventArgs e)
        {
            btReturn.BackColor = Color.DarkOrange;
        }

        private void btReturn_MouseLeave(object sender, EventArgs e)
        {
            btReturn.BackColor = Color.White;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
