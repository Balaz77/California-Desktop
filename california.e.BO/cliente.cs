using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace california.e.BO
{
    public class cliente
    {
        public string nomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public string telefoneCliente { get; set; }
        public string enderecoCliente { get; set; }


        public void cadastrarCliente(cliente cliente)
        {
            //conectando com o banco
            string conexaoBD = "server=localhost; database=california; uid=root; pwd=etec";

            //conexao
            MySqlConnection minhaConexao = new MySqlConnection(conexaoBD);
            minhaConexao.Open();

           
            string sqlcommand = "INSERT INTO cliente (nomeCliente,cpfCliente,telefoneCliente,enderecoCliente)" + "values ('" + cliente.nomeCliente + "','" + cliente.cpfCliente + "','" + cliente.telefoneCliente + "','" + cliente.enderecoCliente + "')";
            MySqlCommand comando = new MySqlCommand(sqlcommand, minhaConexao);

            //executa o comando (query serve para executar)
            comando.ExecuteNonQuery();


        }

    }
}
