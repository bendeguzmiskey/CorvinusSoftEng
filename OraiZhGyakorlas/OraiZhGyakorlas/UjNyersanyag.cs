using OraiZhGyakorlas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraiZhGyakorlas
{
    public partial class UjNyersanyag : Form
    {
        public Nyersanyagok ujNyersanyag;
        public UjNyersanyag()
        {
            InitializeComponent();
            ujNyersanyag = new Nyersanyagok();
            ujNyersanyag.NyersanyagNev = "Új nyersanyag";
            bindingSource1.DataSource = ujNyersanyag;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
