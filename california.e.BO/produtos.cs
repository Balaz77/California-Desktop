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
    class produtos
    {
        public string codProduto { get; set; }
        public string tamanhoProduto { get; set; }
        public string corProduto { get; set; }
        public string categoriaProduto { get; set; }
        public string nomeProduto { get; set; }
        public string valorProduto { get; set; }


        #region cadastrar
        public void cadastrarFunc(produtos produtos)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=123456";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para inserir os funcionarios no banco de dados, onde apresentam os atributos e os values que puxam os dados dos campos 
            string sqlcommand = "INSERT INTO produtos ( tamanhoProd, corProd, categoriaProd, nomeProd, valorProd)" + "values ('"+produtos.tamanhoProduto + "','"+produtos.corProduto+"','"+produtos.categoriaProduto+"','"+produtos.nomeProduto+"','"+produtos.valorProduto+"')";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();


        }
        #endregion

        #region buscar
        //configura o dgv
        public DataTable buscarFunc()
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=123456";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para buscar no banco os funcionarios ja cadastrados
            string sqlcommand = " SELECT * FROM produtos";
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
        public void alterarFunc(produtos produtos)
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=123456";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para alterar os funcionarios dentro do banco
            string sqlcommand = "update produtos set  tamanhoProd='" + produtos.tamanhoProduto + "', corProd='" + produtos.corProduto + "',categoriaProd='" + produtos.categoriaProduto + "',nomeProd='" + produtos.nomeProduto + "',valorProd='" + produtos.valorProduto + "';";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();
        }
        #endregion 

        #region deletar
        //string parametro deveria ser algo como (*classe*->funcionario *string*->funcionario)
        public void deletarFunc(string cpfFunc)
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=123456";

            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //comando para deletar os funcionarios
            string sqlcommand = "delete from funcionario where cpfFunc='" + cpfFunc + "';";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);
            comando.ExecuteNonQuery();
        }
        #endregion

        #region procurar
        public DataTable procuraFunc(string cargoFunc)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=123456";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //comando que busca por algo especifico no banco
            string sqlcommand = "SELECT cargoFunc cargoFunc,usuarioFunc,senhaFunc,nomeFunc,cpfFunc,dtNascimento,telefoneFunc,enderecoFunc FROM funcionario where cargoFunc like '%" + cargoFunc + "%';";
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
