using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giocodellanno
{
    public partial class bicipiti : Form
    {
        public bicipiti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curlman curlman = new curlman();
            curlman.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            curlbila curlbila = new curlbila();
            curlbila.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curlmart curlmart = new curlmart();
            curlmart.Show();
        }
    }
}
