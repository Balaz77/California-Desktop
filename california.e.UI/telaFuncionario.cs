using california.e.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace california.e.UI
{
    public partial class telaFuncionario : Form
    {
        public telaFuncionario()
        {
            InitializeComponent();
        }

        //criando uma especie de array para armazenar os dados 
        List<funcionario> funcionarios = new List<funcionario>();
        funcionario classFuncionario = new funcionario();

        private void CadFun_Click(object sender, EventArgs e)
        {
          
                //recebe os dados dos campos do formulario
                classFuncionario.cargoFunc = cargoFuncTxt.Text;
                classFuncionario.usuarioFunc = usrFuncTxt.Text;
                classFuncionario.senhaFunc = pwdFuncTxt.Text;
                classFuncionario.nomeFunc = nomeFuncTxt.Text; 
                classFuncionario.cpfFunc = cpfFuncTxt.Text;
            try
            {
                //validar dados da data de nascimento 
               classFuncionario.dtNascimento = DateTime.Parse(dtNacFuncTxt.Text);
            }
            catch
            {
                //messagebox apresenta o conteudo caso a date esta errada.
                MessageBox.Show("Insira os dados corretamente!");
            }
                
                classFuncionario.telefoneFunc = telFuncTxt.Text;
                classFuncionario.enderecoFunc = endFuncTxt.Text;

            funcionarios.Add(classFuncionario);
         
          
     
            
                //cadastra o funcionario se o cpf for true (existir)
                classFuncionario.cadastrarFunc(classFuncionario);
                MessageBox.Show("Funcionario inserido com sucesso");

                //limpa os campos
                cargoFuncTxt.Text = "";
                usrFuncTxt.Text = "";
                pwdFuncTxt.Text = "";
                nomeFuncTxt.Text = "";
                cpfFuncTxt.Text = "";
                telFuncTxt.Text = "";
                endFuncTxt.Text = "";
                dtNacFuncTxt.Text = "";
            
        
      
          
                //altera o funcionario se o cpf for false (n existir)
             //   classFuncionario.alterarFunc(classFuncionario);
              //  MessageBox.Show("Dados alterados com sucesso");
            

            dgvFunc.DataSource = classFuncionario.buscarFunc();
           

          //  cpfFuncTxt.Enabled = true;
            infoFunclbl.Text = "Inserir";
            delBtnFunc.Visible = true;




        }

        private void lnkVoltarFun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //manda de volta pro menu
            telaMenu telaMenu = new telaMenu();
            telaMenu.Show();
        }
      

        private void telaFuncionario_Load(object sender, EventArgs e)
        {
            funcionario classFuncionario = new funcionario();
            dgvFunc.DataSource = classFuncionario.buscarFunc();

        }

        //duplo click na tabela ativa as funções de alteração
        private void dgvFunc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargoFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["cargoFunc"].Value.ToString();
            usrFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["usuarioFunc"].Value.ToString();
            pwdFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["senhaFunc"].Value.ToString();
            nomeFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["nomeFunc"].Value.ToString();
            cpfFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["cpfFunc"].Value.ToString();
            dtNacFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["dtNascimento"].Value.ToString();
            telFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["telefoneFunc"].Value.ToString();
            endFuncTxt.Text = dgvFunc.Rows[e.RowIndex].Cells["enderecoFunc"].Value.ToString();


            //mostra os botoes que estavam escondidos e habilita troca
            infoFunclbl.Text = "Alterar";
            cpfFuncTxt.Enabled = false;
            delBtnFunc.Visible = true;

          //  classFuncionario.alterarFunc(classFuncionario);

        }

        //botao para cancelar as atividades como alterar ou excluir
        private void canBtnFunc_Click(object sender, EventArgs e)
        {
            //apresenta uma escolha
            DialogResult resp = MessageBox.Show("Deseja cancelar as atividades?", "Funcionarios", MessageBoxButtons.YesNo);

            //se sim
            if (resp == DialogResult.Yes)
            {
                MessageBox.Show("Você cancelou as atividades.");

                infoFunclbl.Text = "inserir";
                
                cargoFuncTxt.Text = "";
                usrFuncTxt.Text = "";
                pwdFuncTxt.Text = "";
                nomeFuncTxt.Text = "";
                cpfFuncTxt.Text = "";
                telFuncTxt.Text = "";
                endFuncTxt.Text = "";
                dtNacFuncTxt.Text = "";
                cpfFuncTxt.Enabled=true;

                //botão invisivel
                delBtnFunc.Visible=false;


            }

        }

        //botão para deletar
        private void delBtnFunc_Click(object sender, EventArgs e)
        {

            if (cpfFuncTxt.Text == "")
            {
                MessageBox.Show("Por favor digite o CPF no campo.");
            }

            //se a resposta for sim ele vai excluir o funcionario da tabela
            DialogResult result = MessageBox.Show("A exclusão do funcionario será realizada, tem certeza disso?", "Funcionarios", MessageBoxButtons.YesNo);
           
            if (result == DialogResult.Yes) {

                //instanciando
                funcionario classFuncionario = new funcionario();
                //chamando o metodo para excluir 
                //digitar cpf para poder excluir
                classFuncionario.deletarFunc(cpfFuncTxt.Text);
                
                MessageBox.Show("Funcionario foi excluido");

                dgvFunc.DataSource = classFuncionario.buscarFunc();
            }


        
        }

        //pqs=´pesquisa
        //serve para filtrar o que deseja ver
        private void pqsFuncBtn_Click(object sender, EventArgs e)
        {
           funcionario classFuncionario = new funcionario(); 
            dgvFunc.DataSource = classFuncionario.procuraFunc(pqsFuncTxt.Text);
        }

        private void altFuncBtn_Click(object sender, EventArgs e)
        {
            funcionario classfuncionario = new funcionario();

               classFuncionario.cargoFunc = cargoFuncTxt.Text;
               classFuncionario.usuarioFunc = usrFuncTxt.Text;
               classFuncionario.senhaFunc = pwdFuncTxt.Text;
               classFuncionario.nomeFunc = nomeFuncTxt.Text;
               classFuncionario.cpfFunc = cpfFuncTxt.Text;
               classFuncionario.telefoneFunc = telFuncTxt.Text;
               classFuncionario.enderecoFunc = endFuncTxt.Text;
               classFuncionario.dtNascimento = DateTime.Parse(dtNacFuncTxt.Text);

               cargoFuncTxt.Text = "";
               usrFuncTxt.Text = "";
               pwdFuncTxt.Text = "";
               nomeFuncTxt.Text = "";
               cpfFuncTxt.Text = "";
               telFuncTxt.Text = "";
               endFuncTxt.Text = "";
               dtNacFuncTxt.Text = "";

            classFuncionario.alterarFunc(classFuncionario);
        }
    }
}
