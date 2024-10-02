using _2_het.Data;
using _2_het.Models;
using Microsoft.EntityFrameworkCore;

namespace _2_het
{
    public partial class Form1 : Form
    {
        private RendelesDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" };
            _context.Ugyfel.Add(ujUgyfel);
            _context.SaveChanges();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var torlendoUgyfel = dataGridView1.CurrentRow.DataBoundItem as Ugyfel;
                if (torlendoUgyfel != null)
                {
                    _context.Ugyfel.Remove(torlendoUgyfel);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                TermekKategoriaForm termekKategoriaForm = new TermekKategoriaForm();
                termekKategoriaForm.ShowDialog();
        }
    }
}