using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace california.e.UI
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
        }

        private void telaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            telaEstoque telaEstoque = new telaEstoque();
            telaEstoque.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            telaVendas telaVendas = new telaVendas();
            telaVendas.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
           // telaHistorico telaHistorico = new telaHistorico();
           // telaHistorico.Show();
        }

        private void btnCadfun_Click(object sender, EventArgs e)
        {
            telaFuncionario telaFuncionario = new telaFuncionario();
            telaFuncionario.Show();
        }

        private void btnCadcli_Click(object sender, EventArgs e)
        {
            
            telaCliente telaCliente = new telaCliente();
            telaCliente.Show();
        }
    }
}
