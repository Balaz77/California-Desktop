
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
            this.confFuncLbl = new System.Windows.Forms.Label();
            this.confFuncTxt = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cargoFuncTxt = new System.Windows.Forms.TextBox();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.infoFunclbl = new System.Windows.Forms.Label();
            this.canBtnFunc = new System.Windows.Forms.Button();
            this.delBtnProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pqsFuncTxt = new System.Windows.Forms.TextBox();
            this.pqsFuncBtn = new System.Windows.Forms.Button();
            this.altFuncBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // cadFun
            // 
            this.cadFun.Location = new System.Drawing.Point(352, 330);
            this.cadFun.Name = "cadFun";
            this.cadFun.Size = new System.Drawing.Size(186, 24);
            this.cadFun.TabIndex = 44;
            this.cadFun.Text = "Salvar";
            this.cadFun.UseVisualStyleBackColor = true;
            this.cadFun.Click += new System.EventHandler(this.CadFun_Click);
            // 
            // confFuncLbl
            // 
            this.confFuncLbl.AutoSize = true;
            this.confFuncLbl.Location = new System.Drawing.Point(35, 156);
            this.confFuncLbl.Name = "confFuncLbl";
            this.confFuncLbl.Size = new System.Drawing.Size(83, 13);
            this.confFuncLbl.TabIndex = 43;
            this.confFuncLbl.Text = "Confirmar senha";
            // 
            // confFuncTxt
            // 
            this.confFuncTxt.Location = new System.Drawing.Point(38, 172);
            this.confFuncTxt.Name = "confFuncTxt";
            this.confFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.confFuncTxt.TabIndex = 42;
            // 
            // dtNacFuncLbl
            // 
            this.dtNacFuncLbl.AutoSize = true;
            this.dtNacFuncLbl.Location = new System.Drawing.Point(35, 275);
            this.dtNacFuncLbl.Name = "dtNacFuncLbl";
            this.dtNacFuncLbl.Size = new System.Drawing.Size(102, 13);
            this.dtNacFuncLbl.TabIndex = 41;
            this.dtNacFuncLbl.Text = "Data de nascimento";
            // 
            // usrFuncLbl
            // 
            this.usrFuncLbl.AutoSize = true;
            this.usrFuncLbl.Location = new System.Drawing.Point(35, 69);
            this.usrFuncLbl.Name = "usrFuncLbl";
            this.usrFuncLbl.Size = new System.Drawing.Size(43, 13);
            this.usrFuncLbl.TabIndex = 40;
            this.usrFuncLbl.Text = "Usuario";
            // 
            // pwdFuncLbl
            // 
            this.pwdFuncLbl.AutoSize = true;
            this.pwdFuncLbl.Location = new System.Drawing.Point(35, 113);
            this.pwdFuncLbl.Name = "pwdFuncLbl";
            this.pwdFuncLbl.Size = new System.Drawing.Size(38, 13);
            this.pwdFuncLbl.TabIndex = 39;
            this.pwdFuncLbl.Text = "Senha";
            // 
            // endFuncLbl
            // 
            this.endFuncLbl.AutoSize = true;
            this.endFuncLbl.Location = new System.Drawing.Point(35, 358);
            this.endFuncLbl.Name = "endFuncLbl";
            this.endFuncLbl.Size = new System.Drawing.Size(53, 13);
            this.endFuncLbl.TabIndex = 38;
            this.endFuncLbl.Text = "Endereço";
            // 
            // telFuncLbl
            // 
            this.telFuncLbl.AutoSize = true;
            this.telFuncLbl.Location = new System.Drawing.Point(35, 314);
            this.telFuncLbl.Name = "telFuncLbl";
            this.telFuncLbl.Size = new System.Drawing.Size(49, 13);
            this.telFuncLbl.TabIndex = 37;
            this.telFuncLbl.Text = "Telefone";
            // 
            // cpfFuncLbl
            // 
            this.cpfFuncLbl.AutoSize = true;
            this.cpfFuncLbl.Location = new System.Drawing.Point(38, 234);
            this.cpfFuncLbl.Name = "cpfFuncLbl";
            this.cpfFuncLbl.Size = new System.Drawing.Size(27, 13);
            this.cpfFuncLbl.TabIndex = 36;
            this.cpfFuncLbl.Text = "CPF";
            // 
            // nomeFuncLbl
            // 
            this.nomeFuncLbl.AutoSize = true;
            this.nomeFuncLbl.Location = new System.Drawing.Point(35, 194);
            this.nomeFuncLbl.Name = "nomeFuncLbl";
            this.nomeFuncLbl.Size = new System.Drawing.Size(35, 13);
            this.nomeFuncLbl.TabIndex = 35;
            this.nomeFuncLbl.Text = "Nome";
            // 
            // pwdFuncTxt
            // 
            this.pwdFuncTxt.Location = new System.Drawing.Point(38, 129);
            this.pwdFuncTxt.Name = "pwdFuncTxt";
            this.pwdFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.pwdFuncTxt.TabIndex = 34;
            // 
            // usrFuncTxt
            // 
            this.usrFuncTxt.Location = new System.Drawing.Point(38, 85);
            this.usrFuncTxt.Name = "usrFuncTxt";
            this.usrFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.usrFuncTxt.TabIndex = 33;
            // 
            // nomeFuncTxt
            // 
            this.nomeFuncTxt.Location = new System.Drawing.Point(38, 210);
            this.nomeFuncTxt.Name = "nomeFuncTxt";
            this.nomeFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.nomeFuncTxt.TabIndex = 32;
            // 
            // endFuncTxt
            // 
            this.endFuncTxt.Location = new System.Drawing.Point(38, 374);
            this.endFuncTxt.Name = "endFuncTxt";
            this.endFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.endFuncTxt.TabIndex = 31;
            // 
            // telFuncTxt
            // 
            this.telFuncTxt.Location = new System.Drawing.Point(38, 330);
            this.telFuncTxt.Name = "telFuncTxt";
            this.telFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.telFuncTxt.TabIndex = 30;
            // 
            // cpfFuncTxt
            // 
            this.cpfFuncTxt.Location = new System.Drawing.Point(38, 250);
            this.cpfFuncTxt.Name = "cpfFuncTxt";
            this.cpfFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.cpfFuncTxt.TabIndex = 29;
            // 
            // dtNacFuncTxt
            // 
            this.dtNacFuncTxt.Location = new System.Drawing.Point(38, 291);
            this.dtNacFuncTxt.Name = "dtNacFuncTxt";
            this.dtNacFuncTxt.Size = new System.Drawing.Size(132, 20);
            this.dtNacFuncTxt.TabIndex = 28;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Cargo";
            // 
            // cargoFuncTxt
            // 
            this.cargoFuncTxt.Location = new System.Drawing.Point(38, 43);
            this.cargoFuncTxt.Name = "cargoFuncTxt";
            this.cargoFuncTxt.Size = new System.Drawing.Size(203, 20);
            this.cargoFuncTxt.TabIndex = 65;
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Location = new System.Drawing.Point(176, 298);
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
            this.dgvFunc.TabIndex = 68;
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
            // canBtnFunc
            // 
            this.canBtnFunc.Location = new System.Drawing.Point(352, 360);
            this.canBtnFunc.Name = "canBtnFunc";
            this.canBtnFunc.Size = new System.Drawing.Size(106, 24);
            this.canBtnFunc.TabIndex = 70;
            this.canBtnFunc.Text = "Cancelar";
            this.canBtnFunc.UseVisualStyleBackColor = true;
            this.canBtnFunc.Click += new System.EventHandler(this.canBtnFunc_Click);
            // 
            // delBtnProd
            // 
            this.delBtnProd.Location = new System.Drawing.Point(665, 330);
            this.delBtnProd.Name = "delBtnProd";
            this.delBtnProd.Size = new System.Drawing.Size(91, 24);
            this.delBtnProd.TabIndex = 71;
            this.delBtnProd.Text = "Deletar";
            this.delBtnProd.UseVisualStyleBackColor = true;
            this.delBtnProd.Click += new System.EventHandler(this.delBtnFunc_Click);
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
            this.pqsFuncTxt.Name = "pqsFuncTxt";
            this.pqsFuncTxt.Size = new System.Drawing.Size(237, 20);
            this.pqsFuncTxt.TabIndex = 73;
            // 
            // pqsFuncBtn
            // 
            this.pqsFuncBtn.Location = new System.Drawing.Point(650, 83);
            this.pqsFuncBtn.Name = "pqsFuncBtn";
            this.pqsFuncBtn.Size = new System.Drawing.Size(106, 24);
            this.pqsFuncBtn.TabIndex = 74;
            this.pqsFuncBtn.Text = "pesquisar";
            this.pqsFuncBtn.UseVisualStyleBackColor = true;
            this.pqsFuncBtn.Click += new System.EventHandler(this.pqsFuncBtn_Click);
            // 
            // altFuncBtn
            // 
            this.altFuncBtn.Location = new System.Drawing.Point(568, 330);
            this.altFuncBtn.Name = "altFuncBtn";
            this.altFuncBtn.Size = new System.Drawing.Size(91, 24);
            this.altFuncBtn.TabIndex = 75;
            this.altFuncBtn.Text = "Alterar";
            this.altFuncBtn.UseVisualStyleBackColor = true;
            this.altFuncBtn.Click += new System.EventHandler(this.altFuncBtn_Click);
            // 
            // telaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.altFuncBtn);
            this.Controls.Add(this.pqsFuncBtn);
            this.Controls.Add(this.pqsFuncTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBtnProd);
            this.Controls.Add(this.canBtnFunc);
            this.Controls.Add(this.infoFunclbl);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargoFuncTxt);
            this.Controls.Add(this.lnkVoltarFun);
            this.Controls.Add(this.cadFun);
            this.Controls.Add(this.confFuncLbl);
            this.Controls.Add(this.confFuncTxt);
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
        private System.Windows.Forms.Label confFuncLbl;
        private System.Windows.Forms.TextBox confFuncTxt;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cargoFuncTxt;
        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Label infoFunclbl;
        private System.Windows.Forms.Button canBtnFunc;
        private System.Windows.Forms.Button delBtnProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pqsFuncTxt;
        private System.Windows.Forms.Button pqsFuncBtn;
        private System.Windows.Forms.Button altFuncBtn;
    }
}