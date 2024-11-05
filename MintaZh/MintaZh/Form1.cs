using Microsoft.EntityFrameworkCore;
using MintaZh.Models;
using System.ComponentModel;

namespace MintaZh
{
    public partial class Form1 : Form
    {
        ReceptContext context = new ReceptContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NyersanyagListazas();
            FogasListazas();
        }


        private void NyersanyagListazas()
        {
            var hv = from x in context.Nyersanyagok
                     where x.NyersanyagNev.Contains(textBox3.Text)
                     select x;

            nyersanyagokBindingSource.DataSource = hv.ToList();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            NyersanyagListazas();
        }

        private void FogasListazas()
        {
            var hv = from x in context.Fogasok
                     where x.FogasNev.Contains(textBox2.Text)
                     select x;

            fogasokBindingSource.DataSource = hv.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FogasListazas();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiválasztottNyersanyag = (Nyersanyagok)listBox2.SelectedItem;
            var megyseg = (from x in context.MennyisegiEgysegek
                           where x.MennyisegiEgysegId == kiválasztottNyersanyag.MennyisegiEgysegId
                           select x).FirstOrDefault();
            label1.Text = megyseg.EgysegNev;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzávalóListázás();
        }

        private void HozzávalóListázás()
        {
            var id = ((Fogasok)listBox1.SelectedItem).FogasId;

            var hozzávalók = from x in context.Receptek
                             where x.FogasId == id
                             select new Hozzávaló
                             {
                                 ReceptID = x.ReceptId,
                                 FogasID = x.FogasId,
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
            hozzávalóBindingSource.DataSource = hozzávalók.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)listBox2.SelectedItem).NyersanyagId;
            r.FogasId = ((Fogasok)listBox1.SelectedItem).FogasId;
            double m;
            if (!double.TryParse(textBox1.Text, out m)) return;
            r.Mennyiseg4fo = m;
            context.Receptek.Add(r);
            context.SaveChanges();
            HozzávalóListázás(); //Az középsõ rácsot kell újratölteni
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            var törlendõ = (Hozzávaló)hozzávalóBindingSource.Current;

            var törlend = (from x in context.Receptek
                           where x.ReceptId == törlendõ.ReceptID
                           select x).FirstOrDefault();

            context.Receptek.Remove(törlend);
            context.SaveChanges();
            HozzávalóListázás();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                nyersanyagokBindingSource.Add(form2.nyersanyagok);
            }
        }
    }
}
