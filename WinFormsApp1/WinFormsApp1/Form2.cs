using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection;
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            start start = new start();
            start.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-B0RR9IOE;Initial Catalog=""футбольниый клуб"";Integrated Security=True;Encrypt=False";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [футболист]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id_футболиста"]) + "     " + Convert.ToString(sqlReader["фамилия"]) + "      " + Convert.ToString(sqlReader["имя"]) + "      " + Convert.ToString(sqlReader["отчество"]) + "     " + Convert.ToString(sqlReader["дата_рождения"]) + "        " + Convert.ToString(sqlReader["id_страны"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
