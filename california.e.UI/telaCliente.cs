using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using california.e.BO;

namespace california.e.UI
{
    public partial class telaCliente : Form
    {
        public telaCliente()
        {
            InitializeComponent();
        }

        private void CadCli_Click(object sender, EventArgs e)
        {
            if(nomeCliTxt.Text == "" || cpfCliTxt.Text == "" || telefoneCliTxt.Text == "" || endCliTxt.Text == "" )
            {
                MessageBox.Show("Por favor, preencha os campos.");
            }
            else
            {
                MessageBox.Show("Usuário cadastrado.");
                telaMenu telaMenu = new telaMenu();
                telaMenu.Show();
                this.Hide();
            }
        }

        private void telaCliente_Load(object sender, EventArgs e)
        {

        }

        private void lnkVoltarCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }
    }
}
