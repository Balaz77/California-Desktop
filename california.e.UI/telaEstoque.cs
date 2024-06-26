﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using california.e.BO;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace california.e.UI
{
    public partial class telaEstoque : Form
    {
        public telaEstoque()
        {
            InitializeComponent();
        }
        List<produtos> listaProdutos = new List<produtos>();
        produtos produtos = new produtos();
        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }

        private void telaEstoque_Load(object sender, EventArgs e)
        {
            produtos produtos = new produtos();
            dgvProd.DataSource = produtos.buscarProd();
        }

        private void cadProd_Click(object sender, EventArgs e)
        {
            produtos produtos = new produtos();

            if (codProdTxt.Text == "" || tamanhoProdTxt.Text == "" || corProdTxt.Text == "" || ctgProdTxt.Text == "" || NomeProdTxt.Text == "" || ValProdTxt.Text == "")
            {
                 MessageBox.Show("Insira os dados corretamente!");
            }
            else
            {
                produtos.codProduto = codProdTxt.Text;
                produtos.tamanhoProduto = tamanhoProdTxt.Text;
                produtos.corProduto = corProdTxt.Text;
                produtos.categoriaProduto = ctgProdTxt.Text;
                produtos.nomeProduto = NomeProdTxt.Text;
                produtos.valorProduto = decimal.Parse(ValProdTxt.Text);

                MessageBox.Show("Produto cadastrado com exito.");
                produtos.cadastrarProd(produtos);
                listaProdutos.Add(produtos);

                codProdTxt.Text = "";
                tamanhoProdTxt.Text = "";
                corProdTxt.Text = "";
                ctgProdTxt.Text = "";
                NomeProdTxt.Text = "";
                ValProdTxt.Text = "";
            }


           



           

        }

        private void dgvProd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codProdTxt.Text = dgvProd.Rows[e.RowIndex].Cells["codProduto"].Value.ToString();
            tamanhoProdTxt.Text = dgvProd.Rows[e.RowIndex].Cells["tamanhoProduto"].Value.ToString();
            corProdTxt.Text = dgvProd.Rows[e.RowIndex].Cells["corProduto"].Value.ToString();
            ctgProdTxt.Text = dgvProd.Rows[e.RowIndex].Cells["categoriaProduto"].Value.ToString();
            NomeProdTxt.Text = dgvProd.Rows[e.RowIndex].Cells["nomeProduto"].Value.ToString();
            ValProdTxt.Text = dgvProd.Rows[e.RowIndex].Cells["valorProduto"].Value.ToString();



        }

        private void canBtnProd_Click(object sender, EventArgs e)
        {
            
            {
                infoFunclbl.Visible = true;
                infoFunclbl.Text = "Inserir";
                infoFuncLblred.Visible = false;
                infoFunclbl.Visible = true;
                codFuncLbl2.Visible = false;


                codProdTxt.Text = "";
                tamanhoProdTxt.Text = "";
                corProdTxt.Text = "";
                ctgProdTxt.Text = "";
                NomeProdTxt.Text = "";
                ValProdTxt.Text = "";

                codProdTxt.Visible = true;
                tamanhoProdTxt.Visible = true;
                corProdTxt.Visible = true;
                ctgProdTxt.Visible = true;
                NomeProdTxt.Visible = true;
                ValProdTxt.Visible = true;

                codprodlbl.Visible = true;
                tamProdlbl.Visible = true; 
                corProdlbl.Visible = true;
                catProdlbl.Visible = true;
                nomeProdlbl.Visible = true;
                valProdlbl.Visible = true;

                cadProd.Visible = true;
                delBtnProd.Visible = false;



            }
        }

        private void delBtnProd_Click(object sender, EventArgs e)
        {
           
            //se a resposta for sim ele vai excluir o funcionario da tabela
            DialogResult result = MessageBox.Show("A exclusão do produto será realizada, tem certeza disso?", "produtos", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                produtos produtos = new produtos();
                produtos.deletarProd(int.Parse(codProdTxt.Text));
                MessageBox.Show("Produto excluido com exito!");

                dgvProd.DataSource = produtos.buscarProd();
            }
        }

        private void pqsProdBtn_Click(object sender, EventArgs e)
        {
            produtos produtos = new produtos();
            dgvProd.DataSource = produtos.procuraProd(pqsProdTxt.Text);
        }

        private void corProdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoFunclbl.Visible = false;
            infoFunclbl.Text = "Deletar";
            infoFuncLblred.Visible = true;
            infoFunclbl.Visible = false;
            codFuncLbl2.Visible = true;


            codProdTxt.Text = "";
            tamanhoProdTxt.Text = "";
            corProdTxt.Text = "";
            ctgProdTxt.Text = "";
            NomeProdTxt.Text = "";
            ValProdTxt.Text = "";

            codProdTxt.Visible = true;
            tamanhoProdTxt.Visible = false;
            corProdTxt.Visible = false;
            ctgProdTxt.Visible = false;
            QuantProdTxt.Visible = false;
            NomeProdTxt.Visible = false;
            ValProdTxt.Visible = false;

            codprodlbl.Visible = true;
            tamProdlbl.Visible = false;
            corProdlbl.Visible = false;
            catProdlbl.Visible = false;
            qntProdlbl.Visible = false;
            nomeProdlbl.Visible = false;
            valProdlbl.Visible = false;

            cadProd.Visible = false;
            delBtnProd.Visible = true;
        }
    }
    
}

