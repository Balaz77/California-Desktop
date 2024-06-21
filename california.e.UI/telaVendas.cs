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
    public partial class telaVendas : Form
    {
        public telaVendas()
        {
            InitializeComponent();
        }
        vendas vendas = new vendas();

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }

        private void telaVendas_Load(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            dgvProd.DataSource = vendas.buscarProd();
        }

        private void regProdBtn_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();

            if(valVendaTxt.Text =="" || qntVendaTxt.Text=="" || saleVendaTxt.Text == ""|| dtVendaTxt.Text == "")
            {
                MessageBox.Show("Insira os valores corretamente.");
            }
            else
            {
                vendas.precoCompra = decimal.Parse(valVendaTxt.Text);
                vendas.quantidadeCompra = int.Parse(qntVendaTxt.Text);
                vendas.descontoCompra = decimal.Parse(saleVendaTxt.Text);
                try
                {
                    vendas.dtVenda = DateTime.Parse(dtVendaTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Insira a data de forma correta!");
                }
                dgvProd.DataSource = vendas.buscarProd();
                vendas.cadastrarProd(vendas);
            }
           
        }

        private void canBtnProd_Click(object sender, EventArgs e)
        {
            //apresenta uma escolha
            DialogResult resp = MessageBox.Show("Deseja cancelar as atividades?", "Vendas", MessageBoxButtons.YesNo);

            //se sim
            if (resp == DialogResult.Yes)
            {
                MessageBox.Show("Você cancelou as atividades.");

                infoFunclbl.Text = "inserir";

                valVendaTxt.Text = "";
                qntVendaTxt.Text = "";
                saleVendaTxt.Text = "";
                dtVendaTxt.Text = "";


            }

            
        }

        private void dgvProd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            valVendaTxt.Text = dgvProd.Rows[e.RowIndex].Cells["precoCompra"].Value.ToString();
            qntVendaTxt.Text = dgvProd.Rows[e.RowIndex].Cells["quantidadeCompra"].Value.ToString();
            saleVendaTxt.Text = dgvProd.Rows[e.RowIndex].Cells["descontoCompra"].Value.ToString();
            dtVendaTxt.Text = dgvProd.Rows[e.RowIndex].Cells["dtVenda"].Value.ToString();

            vendas vendas = new vendas();
            dgvProd.DataSource = vendas.buscarProd();
        }

        private void pqsProdBtn_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            dgvProd.DataSource = vendas.procuraProd(int.Parse(pqsProdTxt.Text));
        }
    }

}
