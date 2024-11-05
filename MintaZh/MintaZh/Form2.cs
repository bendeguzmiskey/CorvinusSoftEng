using MintaZh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZh
{
    public partial class Form2 : Form
    {
        public Nyersanyagok nyersanyagok;
        public Form2()
        {
            InitializeComponent();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            nyersanyagok = new Nyersanyagok();
            nyersanyagok.NyersanyagNev = textBox1.Text;
            bindingSource1.DataSource = nyersanyagok;
        }
    }
}
