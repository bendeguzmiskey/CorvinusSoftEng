using WinFormsApp2.BookModels;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        FunnyDatabaseContext context = new FunnyDatabaseContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = context.Books.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var keresett = from x in context.Books
                     where x.Title.Contains(textBox1.Text)
                     select x;

            bookBindingSource.DataSource = keresett.ToList();
        }
    }
}
