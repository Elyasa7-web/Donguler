using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Timer_odev : Form
    {
        public Timer_odev()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 30)
            {
                this.label1.BackColor = Color.Red;
            }
            label2.Text=sayac.ToString();
            if (sayac == 40)
            {
                this.label2.BackColor = Color.Yellow;
            }
            label3.Text=sayac.ToString();
            if (sayac == 70)
            {
                this.label3.BackColor = Color.Green;
                sayac = 0;
                timer1.Stop();
            }
        }
    }
}
