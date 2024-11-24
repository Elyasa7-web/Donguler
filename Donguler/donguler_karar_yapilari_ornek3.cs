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
    public partial class donguler_karar_yapilari_ornek3 : Form
    {
        public donguler_karar_yapilari_ornek3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            for (int i=1; i<=sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
