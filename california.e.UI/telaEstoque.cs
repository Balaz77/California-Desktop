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
    public partial class telaEstoque : Form
    {
        public telaEstoque()
        {
            InitializeComponent();
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }
    }
}
