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
    public partial class donguler_pratik2 : Form
    {
        public donguler_pratik2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i=2; i<=10; i+=2)
            {
                toplam = toplam + i;
            }
            label2.Text = toplam.ToString();
        }
    }
}
