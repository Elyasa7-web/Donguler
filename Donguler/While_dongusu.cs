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
    public partial class While_dongusu : Form
    {
        public While_dongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add("Merhaba Elyasa");
                listBox2.Items.Add(i);
                i++;
            }
        }
    }
}
