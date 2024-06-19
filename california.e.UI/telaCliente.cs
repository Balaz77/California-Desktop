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
        List<cliente> clientes = new List<cliente>();

        private void CadCli_Click(object sender, EventArgs e)
        {


           

            //verifica se todos os cmapos estão preenchidos 
            if (nomeCliTxt.Text == "" || cpfCliTxt.Text == "" || telefoneCliTxt.Text == "" || endCliTxt.Text == "" )
            {
                MessageBox.Show("Por favor, preencha os campos.");
            }
            else
            {
                MessageBox.Show("Usuário cadastrado.");
                //chama classe cliente 
                cliente classeCliente = new cliente();

                //recebe os dados 
                classeCliente.nomeCliente = nomeCliTxt.Text;
                classeCliente.cpfCliente = cpfCliTxt.Text;
                classeCliente.telefoneCliente = telefoneCliTxt.Text;
                classeCliente.enderecoCliente = endCliTxt.Text;

                //limpa os campos 
                nomeCliTxt.Text = "";
                cpfCliTxt.Text = "";
                telefoneCliTxt.Text = "";
                endCliTxt.Text = "";
                classeCliente.cadastrarCliente(classeCliente);
            }
           
        }

        private void telaCliente_Load(object sender, EventArgs e)
        {
            cliente classeCliente = new cliente();
        }

        private void lnkVoltarCli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }
    }
}
