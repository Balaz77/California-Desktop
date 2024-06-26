using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace california.e.BO
{
    public class produtos
    {
        public string codProduto { get; set; }
        public string tamanhoProduto { get; set; }
        public string corProduto { get; set; }
        public string categoriaProduto { get; set; }
        public string nomeProduto { get; set; }
        public decimal valorProduto { get; set; }


        #region cadastrar
        public void cadastrarProd(produtos produtos)
        {

            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para inserir os funcionarios no banco de dados, onde apresentam os atributos e os values que puxam os dados dos campos 
            string sqlcommand = "INSERT INTO produto (tamanhoProduto, corProduto, categoriaProduto, nomeProduto, valorProduto)" + "values ('"+produtos.tamanhoProduto + "','"+produtos.corProduto+"','"+produtos.categoriaProduto+"','"+produtos.nomeProduto+"','"+produtos.valorProduto+"')";
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
            string sqlcommand = " SELECT * FROM produto";
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

        //arrumar 
        #region alterar
        //metodo para alterar
        public void alterarProd(produtos produtos)
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para alterar os funcionarios dentro do banco
            string sqlcommand = "update produto set tamanhoProduto='" + produtos.tamanhoProduto + "', corProduto='" + produtos.corProduto + "',categoriaProduto='" + produtos.categoriaProduto + "',nomeProduto='" + produtos.nomeProduto + "',valorProduto='" + produtos.valorProduto + "';";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();
        }
        #endregion 

        #region deletar
        //string parametro deveria ser algo como (*classe*->funcionario *string*->funcionario)
        public void deletarProd(int codProduto)
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //comando para deletar os funcionarios
            string sqlcommand = "delete from produto where codProduto='" + codProduto + "';";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);
            comando.ExecuteNonQuery();
        }
        #endregion

        #region procurar
        public DataTable procuraProd(string nomeProduto)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //comando que busca por algo especifico no banco
            string sqlcommand = "SELECT nomeProduto tamanhoProduto, corProduto, categoriaProduto, nomeProduto, valorProduto FROM produto where nomeProduto like '%" + nomeProduto + "%';";
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
