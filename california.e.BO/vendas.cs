using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace california.e.BO
{
  public class vendas
    {

        public decimal precoCompra { get; set; }
        public int quantidadeCompra { get; set; }
        public decimal descontoCompra { get; set; }
        public DateTime dtVenda { get; set; }
        public int codCompra { get; set; }

        #region cadastrar
        //este serve para cadastrar o funcionario dentro do banco
        public void cadastrarProd(vendas vendas)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para inserir os funcionarios no banco de dados, onde apresentam os atributos e os values que puxam os dados dos campos 
            string sqlcommand = "INSERT INTO compras (precoCompra,quantidadeCompra,descontoCompra,dtVenda)" + "values ('"+vendas.precoCompra+"','"+vendas.quantidadeCompra+"','"+vendas.descontoCompra+"','"+vendas.dtVenda.ToString("yyyy-MM-dd")+"')";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);
            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();


        }
        #endregion

        #region buscar
        //configura o dgv
        public DataTable buscarProd()
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para buscar no banco os funcionarios ja cadastrados
            string sqlcommand = " SELECT * FROM compras";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();

            //isso aqui serve para configurar o datagrid pra mostrara os dados.
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sqlcommand, minhaConexao);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;
        }
        #endregion

        #region procurar
        public DataTable procuraProd(int codCompra)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //comando que busca por algo especifico no banco
            string sqlcommand = "SELECT precoCompra,quantidadeCompra,descontoCompra,dtVenda FROM compras where codCompra like '%" + codCompra + "%';";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();

            //isso aqui serve para configurar o datagrid pra mostrara os dados.
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sqlcommand, minhaConexao);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;


        }
        #endregion


    }
}
