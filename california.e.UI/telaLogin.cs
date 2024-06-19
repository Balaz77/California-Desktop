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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void EnterUser_Click(object sender, EventArgs e)
        {
            if (logUserTxt.Text == "" || logPwdTxt.Text == "" )
            {
                MessageBox.Show("Acesso Negado");
            }
            else
            {
                //MessageBox.Show("Acesso Liberado");
                //telaMenu telaMenu = new telaMenu();
                //telaMenu.Show();
                //this.Hide();

                DateTime horaentrada = DateTime.Now;
                DateTime horasaida = Convert.ToDateTime("18/06/2024 23:34:00");

                funcionario classLogin = new funcionario();

                if (classLogin.validarFunc(logUserTxt.Text, logPwdTxt.Text)==true)
                {
                    telaMenu telaInicio = new telaMenu();
                    telaInicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha errados!");
                }
            }
        }
    }
}
