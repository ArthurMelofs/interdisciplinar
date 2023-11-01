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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "admin" && TxtSenha.Text == "admin")
            {
                Telainicia objTelaInicial = new Telainicia();
                objTelaInicial.Show();
                this.Visible = false;
            } else {
                MessageBox.Show("Usuario ou senha incorreta");
            }

        }
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            TabelaCadastro objTabelaCadastro = new TabelaCadastro();
            objTabelaCadastro.Show();
            this.Visible = false;
        }
    }
}
