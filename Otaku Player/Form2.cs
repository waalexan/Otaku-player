using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otaku_Player
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void close()
        {
            this.Close();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            close();
        }
    }
}
