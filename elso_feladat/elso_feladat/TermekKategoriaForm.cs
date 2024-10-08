using elso_feladat.Data;
using elso_feladat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace elso_feladat
{
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext _context;

        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }

        private void LoadKategoriak()
        {
            // Az összes kategória lekérdezése az adatbázisból
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            // TreeView tartalmának törlése
            treeViewKategoriak.Nodes.Clear();

            // Főkategóriák hozzáadása a TreeView-hoz
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }

        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }

        private void átnevezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewKategoriak.SelectedNode.BeginEdit();
        }

        private void újFőkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria kategoria = new TermekKategoria();
            kategoria.Nev = "Új kategória";
            kategoria.SzuloKategoriaId = null;
            _context.TermekKategoria.Add(kategoria);
            _context.SaveChanges();
            TreeNode uj = new TreeNode(kategoria.Nev);
            uj.Tag = kategoria;
            treeViewKategoriak.Nodes.Add(uj);
            treeViewKategoriak.SelectedNode = uj;
        }

        private void újAlkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria termekKategoria = new TermekKategoria();
            termekKategoria.Nev = "Új kategória";
            termekKategoria.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).KategoriaId;
            _context.TermekKategoria.Add(termekKategoria);
            _context.SaveChanges();
            TreeNode uj = new TreeNode(termekKategoria.Nev);
            uj.Tag = termekKategoria;
            treeViewKategoriak.SelectedNode.Nodes.Add(uj);
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
            {
                TermekKategoria kategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                _context.TermekKategoria.Remove(kategoria);
                _context.SaveChanges();
                treeViewKategoriak.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Nem törölhető kategória, mert van alkategóriája!");
            }
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKategoriak();
        }
        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && !string.IsNullOrEmpty(e.Label))
            {
                TermekKategoria kategoria = (TermekKategoria)e.Node.Tag;
                kategoria.Nev = e.Label;
                _context.SaveChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();
            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            var katlis = (from x in _context.TermekKategoria select x).ToList();

            XElement Kategoriak = new XElement("Kategóriák");
            xdoc.Add(Kategoriak);
            var fokategoriak = from elem in _context.TermekKategoria
                               where elem.SzuloKategoriaId == null
                               select elem;


            foreach (var elem in fokategoriak)
            {
                XElement FoKategoria = new XElement("Főkategória");
                Kategoriak.Add(FoKategoria);
                XAttribute attribute0 = new XAttribute($"KategoriaID", $"{elem.KategoriaId}");
                FoKategoria.Add(attribute0);
                XAttribute attribute00 = new XAttribute($"Nev", $"{elem.Nev}");
                FoKategoria.Add(attribute00);

                var alkategoriak = from x in katlis where x.SzuloKategoriaId == elem.KategoriaId select x;

                foreach (var alkat in alkategoriak)
                {

                    XElement alKategoria = new XElement("Alkategória");
                    FoKategoria.Add(alKategoria);
                    XAttribute attribute1 = new XAttribute($"KategoriaID", $"{alkat.KategoriaId}");
                    alKategoria.Add(attribute1);
                    XAttribute attribute2 = new XAttribute($"Nev", $"{alkat.Nev}");
                    alKategoria.Add(attribute2);
                }

            }
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                xdoc.Save(dialog.FileName);
            }
        }
    }

}
