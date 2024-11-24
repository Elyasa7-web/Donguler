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
    public partial class While_dongusu_2 : Form
    {
        public While_dongusu_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int toplam = 0;
            while (i <= 5)
            {
                toplam = toplam + i;
                i++;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
