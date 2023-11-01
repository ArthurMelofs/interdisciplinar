using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interdisciplinar
{
    public partial class TelaCadastros : Form
    {
        public TelaCadastros()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrou feito com sucesso");
            TabelaCadastro objTabelaCadastro = new TabelaCadastro();
            objTabelaCadastro.Show();
            this.Visible = false;
        }
    }
}
