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
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                nyersanyagok = new Nyersanyagok();
                nyersanyagok.NyersanyagNev = textBox1.Text;
                bindingSource1.DataSource = nyersanyagok;
                this.Close();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "A név nem lehet üres");
            }
        }

        private bool CheckName(string név)
        {
            return !string.IsNullOrEmpty(név);
        }
    }
}
