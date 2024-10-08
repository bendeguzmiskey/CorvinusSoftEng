using elso_feladat.Models;
using elso_feladat.Data;
namespace elso_feladat
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
        private void LoadData()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ujButton_Click(object sender, EventArgs e)
        {
            var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" };
            _context.Ugyfel.Add(ujUgyfel);
            _context.SaveChanges();
            LoadData();
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            LoadData();
        }

        private void mentesButton_Click(object sender, EventArgs e)
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

        private void frissitesButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TermekKategoriaForm termekKategoriaForm = new TermekKategoriaForm();
            termekKategoriaForm.ShowDialog();
        }
    }
}
