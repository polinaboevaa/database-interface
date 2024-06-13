using System.ComponentModel;
using System.Windows.Forms.Layout;

namespace WinFormsApp1
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void футбольный_клуб_Load(object sender, EventArgs e)
        {

        }

        private void clubs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void players_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void comands_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
