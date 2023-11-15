using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace interdisciplinar
{
    public partial class Telainicia : Form
    {
        public Telainicia()
        {
            InitializeComponent();
            CarregarDadosBanco();
        }
        private void CarregarDadosBanco()
        {
            string conexao = "server=Localhost;database=telalogin;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from nv_Pedido, pedido_Item, Produto", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvTelainicial.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
