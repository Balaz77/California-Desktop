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
                MessageBox.Show("Acesso Liberado");
                telaMenu telaMenu = new telaMenu();
                telaMenu.Show();
                this.Hide();
            }
        }
    }
}
