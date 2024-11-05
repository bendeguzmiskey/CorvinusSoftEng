using Microsoft.EntityFrameworkCore;
using OraiZhGyakorlas.Models;
using System.ComponentModel;

namespace OraiZhGyakorlas
{
    public partial class Form1 : Form
    {
        ReceptContext context = new ReceptContext();
        BindingList<Nyersanyagok> nyersanyagokBindingList = new BindingList<Nyersanyagok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nyersanyagokBindingList = context.Nyersanyagok.Local.ToBindingList();
            context.Nyersanyagok.Load();
            nyersanyagokBindingSource.DataSource = nyersanyagokBindingList;
            context.MennyisegiEgysegek.Load();
            mennyisegiEgysegekBindingSource.DataSource = context.MennyisegiEgysegek.Local.ToBindingList();

            var xx = from x in context.Nyersanyagok
                     select new
                     {
                         x.NyersanyagId,
                         x.NyersanyagNev,
                         x.MennyisegiEgyseg.EgysegNev
                     };
            dataGridView2.DataSource = xx.ToList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void AddViaContext_Click(object sender, EventArgs e)
        {
            Nyersanyagok ujNyersanyag = new Nyersanyagok()
            {
                NyersanyagNev = "Új ctx nyersanyag",
                MennyisegiEgysegId = 1,
                Egysegar = 666
            };
            context.Nyersanyagok.Local.Add(ujNyersanyag);
        }

        private void AddViaBL_Click(object sender, EventArgs e)
        {
            Nyersanyagok ujNyersanyag = new Nyersanyagok()
            {
                NyersanyagNev = "Új BL nyersanyag",
                MennyisegiEgysegId = 1,
                Egysegar = 666
            };

            nyersanyagokBindingList.Add(ujNyersanyag);
        }

        private void AddViaBindingSource_Click(object sender, EventArgs e)
        {
            Nyersanyagok ujNyersanyag = new Nyersanyagok()
            {
                NyersanyagNev = "Új BS nyersanyag",
                MennyisegiEgysegId = 1,
                Egysegar = 666
            };
            nyersanyagokBindingSource.Add(ujNyersanyag);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                nyersanyagokBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {

                MessageBox.Show("An error occurred while deleting");
            }
        }

        private void UjNyersAnyagButton_Click(object sender, EventArgs e)
        {
            UjNyersanyag uj = new UjNyersanyag();
            if (uj.ShowDialog() == DialogResult.OK)
            {
                nyersanyagokBindingSource.Add(uj.ujNyersanyag);
            }
        }
    }
}
