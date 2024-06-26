
namespace california.e.UI
{
    partial class telaFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadFun = new System.Windows.Forms.Button();
            this.dtNacFuncLbl = new System.Windows.Forms.Label();
            this.usrFuncLbl = new System.Windows.Forms.Label();
            this.pwdFuncLbl = new System.Windows.Forms.Label();
            this.endFuncLbl = new System.Windows.Forms.Label();
            this.telFuncLbl = new System.Windows.Forms.Label();
            this.cpfFuncLbl = new System.Windows.Forms.Label();
            this.nomeFuncLbl = new System.Windows.Forms.Label();
            this.pwdFuncTxt = new System.Windows.Forms.TextBox();
            this.usrFuncTxt = new System.Windows.Forms.TextBox();
            this.nomeFuncTxt = new System.Windows.Forms.TextBox();
            this.endFuncTxt = new System.Windows.Forms.TextBox();
            this.telFuncTxt = new System.Windows.Forms.TextBox();
            this.cpfFuncTxt = new System.Windows.Forms.TextBox();
            this.dtNacFuncTxt = new System.Windows.Forms.TextBox();
            this.lblSubtFunc = new System.Windows.Forms.Label();
            this.lblTtlFunc = new System.Windows.Forms.Label();
            this.lnkVoltarFun = new System.Windows.Forms.LinkLabel();
            this.cargoFuncLbl = new System.Windows.Forms.Label();
            this.cargoFuncTxt = new System.Windows.Forms.TextBox();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.infoFunclbl = new System.Windows.Forms.Label();
            this.cadBtnFunc = new System.Windows.Forms.Button();
            this.delBtnFunc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pqsFuncTxt = new System.Windows.Forms.TextBox();
            this.pqsFuncBtn = new System.Windows.Forms.Button();
            this.ExcBtnFunc = new System.Windows.Forms.Button();
            this.cpfFuncLbl2 = new System.Windows.Forms.Label();
            this.infoFunclblred = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // cadFun
            // 
            this.cadFun.Location = new System.Drawing.Point(352, 357);
            this.cadFun.Name = "cadFun";
            this.cadFun.Size = new System.Drawing.Size(152, 24);
            this.cadFun.TabIndex = 9;
            this.cadFun.Text = "Salvar";
            this.cadFun.UseVisualStyleBackColor = true;
            this.cadFun.Click += new System.EventHandler(this.CadFun_Click);
            // 
            // dtNacFuncLbl
            // 
            this.dtNacFuncLbl.AutoSize = true;
            this.dtNacFuncLbl.Location = new System.Drawing.Point(43, 251);
            this.dtNacFuncLbl.Name = "dtNacFuncLbl";
            this.dtNacFuncLbl.Size = new System.Drawing.Size(102, 13);
            this.dtNacFuncLbl.TabIndex = 41;
            this.dtNacFuncLbl.Text = "Data de nascimento";
            // 
            // usrFuncLbl
            // 
            this.usrFuncLbl.AutoSize = true;
            this.usrFuncLbl.Location = new System.Drawing.Point(43, 87);
            this.usrFuncLbl.Name = "usrFuncLbl";
            this.usrFuncLbl.Size = new System.Drawing.Size(43, 13);
            this.usrFuncLbl.TabIndex = 40;
            this.usrFuncLbl.Text = "Usuario";
            this.usrFuncLbl.Click += new System.EventHandler(this.usrFuncLbl_Click);
            // 
            // pwdFuncLbl
            // 
            this.pwdFuncLbl.AutoSize = true;
            this.pwdFuncLbl.Location = new System.Drawing.Point(43, 131);
            this.pwdFuncLbl.Name = "pwdFuncLbl";
            this.pwdFuncLbl.Size = new System.Drawing.Size(38, 13);
            this.pwdFuncLbl.TabIndex = 39;
            this.pwdFuncLbl.Text = "Senha";
            // 
            // endFuncLbl
            // 
            this.endFuncLbl.AutoSize = true;
            this.endFuncLbl.Location = new System.Drawing.Point(43, 334);
            this.endFuncLbl.Name = "endFuncLbl";
            this.endFuncLbl.Size = new System.Drawing.Size(53, 13);
            this.endFuncLbl.TabIndex = 38;
            this.endFuncLbl.Text = "Endereço";
            // 
            // telFuncLbl
            // 
            this.telFuncLbl.AutoSize = true;
            this.telFuncLbl.Location = new System.Drawing.Point(43, 290);
            this.telFuncLbl.Name = "telFuncLbl";
            this.telFuncLbl.Size = new System.Drawing.Size(49, 13);
            this.telFuncLbl.TabIndex = 37;
            this.telFuncLbl.Text = "Telefone";
            // 
            // cpfFuncLbl
            // 
            this.cpfFuncLbl.AutoSize = true;
            this.cpfFuncLbl.Location = new System.Drawing.Point(46, 210);
            this.cpfFuncLbl.Name = "cpfFuncLbl";
            this.cpfFuncLbl.Size = new System.Drawing.Size(27, 13);
            this.cpfFuncLbl.TabIndex = 36;
            this.cpfFuncLbl.Text = "CPF";
            // 
            // nomeFuncLbl
            // 
            this.nomeFuncLbl.AutoSize = true;
            this.nomeFuncLbl.Location = new System.Drawing.Point(43, 170);
            this.nomeFuncLbl.Name = "nomeFuncLbl";
            this.nomeFuncLbl.Size = new System.Drawing.Size(35, 13);
            this.nomeFuncLbl.TabIndex = 35;
            this.nomeFuncLbl.Text = "Nome";
            // 
            // pwdFuncTxt
            // 
            this.pwdFuncTxt.Location = new System.Drawing.Point(46, 147);
            this.pwdFuncTxt.MaxLength = 20;
            this.pwdFuncTxt.Name = "pwdFuncTxt";
            this.pwdFuncTxt.PasswordChar = '*';
            this.pwdFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.pwdFuncTxt.TabIndex = 3;
            // 
            // usrFuncTxt
            // 
            this.usrFuncTxt.Location = new System.Drawing.Point(46, 103);
            this.usrFuncTxt.MaxLength = 30;
            this.usrFuncTxt.Name = "usrFuncTxt";
            this.usrFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.usrFuncTxt.TabIndex = 2;
            // 
            // nomeFuncTxt
            // 
            this.nomeFuncTxt.Location = new System.Drawing.Point(46, 186);
            this.nomeFuncTxt.MaxLength = 300;
            this.nomeFuncTxt.Name = "nomeFuncTxt";
            this.nomeFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.nomeFuncTxt.TabIndex = 4;
            // 
            // endFuncTxt
            // 
            this.endFuncTxt.Location = new System.Drawing.Point(46, 350);
            this.endFuncTxt.MaxLength = 40;
            this.endFuncTxt.Name = "endFuncTxt";
            this.endFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.endFuncTxt.TabIndex = 8;
            // 
            // telFuncTxt
            // 
            this.telFuncTxt.Location = new System.Drawing.Point(46, 306);
            this.telFuncTxt.MaxLength = 14;
            this.telFuncTxt.Name = "telFuncTxt";
            this.telFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.telFuncTxt.TabIndex = 7;
            // 
            // cpfFuncTxt
            // 
            this.cpfFuncTxt.Location = new System.Drawing.Point(46, 226);
            this.cpfFuncTxt.MaxLength = 11;
            this.cpfFuncTxt.Name = "cpfFuncTxt";
            this.cpfFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.cpfFuncTxt.TabIndex = 5;
            // 
            // dtNacFuncTxt
            // 
            this.dtNacFuncTxt.Location = new System.Drawing.Point(46, 267);
            this.dtNacFuncTxt.MaxLength = 12;
            this.dtNacFuncTxt.Name = "dtNacFuncTxt";
            this.dtNacFuncTxt.Size = new System.Drawing.Size(132, 20);
            this.dtNacFuncTxt.TabIndex = 6;
            // 
            // lblSubtFunc
            // 
            this.lblSubtFunc.AutoSize = true;
            this.lblSubtFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtFunc.Location = new System.Drawing.Point(347, 47);
            this.lblSubtFunc.Name = "lblSubtFunc";
            this.lblSubtFunc.Size = new System.Drawing.Size(238, 25);
            this.lblSubtFunc.TabIndex = 27;
            this.lblSubtFunc.Text = "Cadastro Funcionario";
            // 
            // lblTtlFunc
            // 
            this.lblTtlFunc.AutoSize = true;
            this.lblTtlFunc.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlFunc.Location = new System.Drawing.Point(614, -10);
            this.lblTtlFunc.Name = "lblTtlFunc";
            this.lblTtlFunc.Size = new System.Drawing.Size(196, 48);
            this.lblTtlFunc.TabIndex = 26;
            this.lblTtlFunc.Text = "California ";
            // 
            // lnkVoltarFun
            // 
            this.lnkVoltarFun.AutoSize = true;
            this.lnkVoltarFun.Location = new System.Drawing.Point(678, 405);
            this.lnkVoltarFun.Name = "lnkVoltarFun";
            this.lnkVoltarFun.Size = new System.Drawing.Size(78, 13);
            this.lnkVoltarFun.TabIndex = 64;
            this.lnkVoltarFun.TabStop = true;
            this.lnkVoltarFun.Text = "Voltar ao menu";
            this.lnkVoltarFun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVoltarFun_LinkClicked);
            // 
            // cargoFuncLbl
            // 
            this.cargoFuncLbl.AutoSize = true;
            this.cargoFuncLbl.Location = new System.Drawing.Point(43, 45);
            this.cargoFuncLbl.Name = "cargoFuncLbl";
            this.cargoFuncLbl.Size = new System.Drawing.Size(35, 13);
            this.cargoFuncLbl.TabIndex = 66;
            this.cargoFuncLbl.Text = "Cargo";
            // 
            // cargoFuncTxt
            // 
            this.cargoFuncTxt.Location = new System.Drawing.Point(46, 61);
            this.cargoFuncTxt.MaxLength = 30;
            this.cargoFuncTxt.Name = "cargoFuncTxt";
            this.cargoFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.cargoFuncTxt.TabIndex = 1;
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Location = new System.Drawing.Point(184, 274);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(0, 13);
            this.dateTimeLbl.TabIndex = 67;
            // 
            // dgvFunc
            // 
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(352, 107);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.Size = new System.Drawing.Size(404, 214);
            this.dgvFunc.TabIndex = 12;
            this.dgvFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellContentClick);
            // 
            // infoFunclbl
            // 
            this.infoFunclbl.AutoSize = true;
            this.infoFunclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFunclbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.infoFunclbl.Location = new System.Drawing.Point(591, 52);
            this.infoFunclbl.Name = "infoFunclbl";
            this.infoFunclbl.Size = new System.Drawing.Size(0, 18);
            this.infoFunclbl.TabIndex = 69;
            // 
            // cadBtnFunc
            // 
            this.cadBtnFunc.Location = new System.Drawing.Point(352, 327);
            this.cadBtnFunc.Name = "cadBtnFunc";
            this.cadBtnFunc.Size = new System.Drawing.Size(206, 24);
            this.cadBtnFunc.TabIndex = 10;
            this.cadBtnFunc.Text = "Modo de cadastro";
            this.cadBtnFunc.UseVisualStyleBackColor = true;
            this.cadBtnFunc.Click += new System.EventHandler(this.canBtnFunc_Click);
            // 
            // delBtnFunc
            // 
            this.delBtnFunc.Location = new System.Drawing.Point(650, 357);
            this.delBtnFunc.Name = "delBtnFunc";
            this.delBtnFunc.Size = new System.Drawing.Size(106, 24);
            this.delBtnFunc.TabIndex = 11;
            this.delBtnFunc.Text = "Deletar";
            this.delBtnFunc.UseVisualStyleBackColor = true;
            this.delBtnFunc.Click += new System.EventHandler(this.delBtnFunc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Cargo";
            // 
            // pqsFuncTxt
            // 
            this.pqsFuncTxt.Location = new System.Drawing.Point(407, 84);
            this.pqsFuncTxt.MaxLength = 30;
            this.pqsFuncTxt.Name = "pqsFuncTxt";
            this.pqsFuncTxt.Size = new System.Drawing.Size(237, 20);
            this.pqsFuncTxt.TabIndex = 13;
            // 
            // pqsFuncBtn
            // 
            this.pqsFuncBtn.Location = new System.Drawing.Point(650, 83);
            this.pqsFuncBtn.Name = "pqsFuncBtn";
            this.pqsFuncBtn.Size = new System.Drawing.Size(106, 24);
            this.pqsFuncBtn.TabIndex = 14;
            this.pqsFuncBtn.Text = "pesquisar";
            this.pqsFuncBtn.UseVisualStyleBackColor = true;
            this.pqsFuncBtn.Click += new System.EventHandler(this.pqsFuncBtn_Click);
            // 
            // ExcBtnFunc
            // 
            this.ExcBtnFunc.Location = new System.Drawing.Point(564, 327);
            this.ExcBtnFunc.Name = "ExcBtnFunc";
            this.ExcBtnFunc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExcBtnFunc.Size = new System.Drawing.Size(192, 24);
            this.ExcBtnFunc.TabIndex = 73;
            this.ExcBtnFunc.Text = "Modo de deleção";
            this.ExcBtnFunc.UseVisualStyleBackColor = true;
            this.ExcBtnFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpfFuncLbl2
            // 
            this.cpfFuncLbl2.AutoSize = true;
            this.cpfFuncLbl2.ForeColor = System.Drawing.Color.DarkRed;
            this.cpfFuncLbl2.Location = new System.Drawing.Point(46, 251);
            this.cpfFuncLbl2.Name = "cpfFuncLbl2";
            this.cpfFuncLbl2.Size = new System.Drawing.Size(252, 13);
            this.cpfFuncLbl2.TabIndex = 74;
            this.cpfFuncLbl2.Text = "Por favor, insira o CPF do funcionário a ser deletado";
            this.cpfFuncLbl2.Visible = false;
            // 
            // infoFunclblred
            // 
            this.infoFunclblred.AutoSize = true;
            this.infoFunclblred.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFunclblred.ForeColor = System.Drawing.Color.DarkRed;
            this.infoFunclblred.Location = new System.Drawing.Point(597, 52);
            this.infoFunclblred.Name = "infoFunclblred";
            this.infoFunclblred.Size = new System.Drawing.Size(0, 18);
            this.infoFunclblred.TabIndex = 75;
            // 
            // telaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoFunclblred);
            this.Controls.Add(this.cpfFuncLbl2);
            this.Controls.Add(this.ExcBtnFunc);
            this.Controls.Add(this.pqsFuncBtn);
            this.Controls.Add(this.pqsFuncTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBtnFunc);
            this.Controls.Add(this.cadBtnFunc);
            this.Controls.Add(this.infoFunclbl);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.cargoFuncLbl);
            this.Controls.Add(this.cargoFuncTxt);
            this.Controls.Add(this.lnkVoltarFun);
            this.Controls.Add(this.cadFun);
            this.Controls.Add(this.dtNacFuncLbl);
            this.Controls.Add(this.usrFuncLbl);
            this.Controls.Add(this.pwdFuncLbl);
            this.Controls.Add(this.endFuncLbl);
            this.Controls.Add(this.telFuncLbl);
            this.Controls.Add(this.cpfFuncLbl);
            this.Controls.Add(this.nomeFuncLbl);
            this.Controls.Add(this.pwdFuncTxt);
            this.Controls.Add(this.usrFuncTxt);
            this.Controls.Add(this.nomeFuncTxt);
            this.Controls.Add(this.endFuncTxt);
            this.Controls.Add(this.telFuncTxt);
            this.Controls.Add(this.cpfFuncTxt);
            this.Controls.Add(this.dtNacFuncTxt);
            this.Controls.Add(this.lblSubtFunc);
            this.Controls.Add(this.lblTtlFunc);
            this.Name = "telaFuncionario";
            this.Text = "telaFuncionario";
            this.Load += new System.EventHandler(this.telaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadFun;
        private System.Windows.Forms.Label dtNacFuncLbl;
        private System.Windows.Forms.Label usrFuncLbl;
        private System.Windows.Forms.Label pwdFuncLbl;
        private System.Windows.Forms.Label endFuncLbl;
        private System.Windows.Forms.Label telFuncLbl;
        private System.Windows.Forms.Label cpfFuncLbl;
        private System.Windows.Forms.Label nomeFuncLbl;
        private System.Windows.Forms.TextBox pwdFuncTxt;
        private System.Windows.Forms.TextBox usrFuncTxt;
        private System.Windows.Forms.TextBox nomeFuncTxt;
        private System.Windows.Forms.TextBox endFuncTxt;
        private System.Windows.Forms.TextBox telFuncTxt;
        private System.Windows.Forms.TextBox cpfFuncTxt;
        private System.Windows.Forms.TextBox dtNacFuncTxt;
        private System.Windows.Forms.Label lblSubtFunc;
        private System.Windows.Forms.Label lblTtlFunc;
        private System.Windows.Forms.LinkLabel lnkVoltarFun;
        private System.Windows.Forms.Label cargoFuncLbl;
        private System.Windows.Forms.TextBox cargoFuncTxt;
        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Label infoFunclbl;
        private System.Windows.Forms.Button cadBtnFunc;
        private System.Windows.Forms.Button delBtnFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pqsFuncTxt;
        private System.Windows.Forms.Button pqsFuncBtn;
        private System.Windows.Forms.Button ExcBtnFunc;
        private System.Windows.Forms.Label cpfFuncLbl2;
        private System.Windows.Forms.Label infoFunclblred;
    }
}