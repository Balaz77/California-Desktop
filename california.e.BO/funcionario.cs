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
    public class funcionario
    {
        #region atributos
        //atributos do banco california
        public string cargoFunc { get; set; }
        public string usuarioFunc { get; set; }
        public string senhaFunc { get; set; }
        public string nomeFunc { get; set; }
        public string cpfFunc { get; set; }
        public DateTime  dtNascimento { get; set; }
        public string telefoneFunc { get; set; }
        public string enderecoFunc { get; set; }
        #endregion

       

        #region cadastrar
        //este serve para cadastrar o funcionario dentro do banco
        public void cadastrarFunc(funcionario funcionario)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec"; //etec
            
            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para inserir os funcionarios no banco de dados, onde apresentam os atributos e os values que puxam os dados dos campos 
            string sqlcommand = "INSERT INTO funcionario (cargoFunc,usuarioFunc,senhaFunc,nomeFunc,cpfFunc,dtNascimento,telefoneFunc,enderecoFunc)" +  "values ('" + funcionario.cargoFunc + "','"+funcionario.usuarioFunc+"','"+funcionario.senhaFunc+"','" + funcionario.nomeFunc + "','" + funcionario.cpfFunc + "','" + funcionario.dtNascimento.ToString("yyyy-MM-dd") + "','" + funcionario.telefoneFunc + "','" + funcionario.enderecoFunc+"')";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();
            
            
        }
        #endregion

        #region buscar
        //configura o dgv
        public DataTable buscarFunc()
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para buscar no banco os funcionarios ja cadastrados
            string sqlcommand = " SELECT * FROM funcionario";
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
        public void alterarFunc(funcionario funcionario)
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para alterar os funcionarios dentro do banco
            string sqlcommand = "update funcionario set cargoFunc='" + funcionario.cargoFunc + "',usuarioFunc='" + funcionario.usuarioFunc + "',senhaFunc='" + funcionario.senhaFunc + "',nomeFunc='" + funcionario.nomeFunc + "',cpfFunc='" + funcionario.cpfFunc + "',dtNascimento='" + funcionario.dtNascimento.ToString("yyyy-MM-dd") + "',telefoneFunc='" + funcionario.telefoneFunc + "',enderecoFunc='" + funcionario.enderecoFunc + "' where cpfFunc ='"+funcionario.cpfFunc+"' ;";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();
        }
        #endregion 

        #region deletar
        //string parametro deveria ser algo como (*classe*->funcionario *string*->funcionario)
        public void deletarFunc(string cpfFunc)
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

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
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

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

        #region validar 
        public bool validarFunc(string usuarioFunc, string senhaFunc )
        {
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

            //este comando serve para buscar no banco os funcionarios ja cadastrados
            string sqlcommand = " SELECT * FROM funcionario where usuarioFunc='" + usuarioFunc +"'and senhaFunc='" + senhaFunc + "' ";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();

            //isso aqui serve para configurar o datagrid pra mostrara os dados.
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sqlcommand, minhaConexao);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
