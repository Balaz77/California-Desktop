
namespace california.e.UI
{
    partial class telaCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeCliTxt = new System.Windows.Forms.TextBox();
            this.endCliTxt = new System.Windows.Forms.TextBox();
            this.telefoneCliTxt = new System.Windows.Forms.TextBox();
            this.cpfCliTxt = new System.Windows.Forms.TextBox();
            this.lblSubt = new System.Windows.Forms.Label();
            this.lblTitl = new System.Windows.Forms.Label();
            this.cadCliBtn = new System.Windows.Forms.Button();
            this.voltarCliLkn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome";
            // 
            // nomeCliTxt
            // 
            this.nomeCliTxt.Location = new System.Drawing.Point(266, 141);
            this.nomeCliTxt.Name = "nomeCliTxt";
            this.nomeCliTxt.Size = new System.Drawing.Size(232, 20);
            this.nomeCliTxt.TabIndex = 48;
            // 
            // endCliTxt
            // 
            this.endCliTxt.Location = new System.Drawing.Point(266, 277);
            this.endCliTxt.Name = "endCliTxt";
            this.endCliTxt.Size = new System.Drawing.Size(232, 20);
            this.endCliTxt.TabIndex = 47;
            // 
            // telefoneCliTxt
            // 
            this.telefoneCliTxt.Location = new System.Drawing.Point(266, 233);
            this.telefoneCliTxt.Name = "telefoneCliTxt";
            this.telefoneCliTxt.Size = new System.Drawing.Size(232, 20);
            this.telefoneCliTxt.TabIndex = 46;
            // 
            // cpfCliTxt
            // 
            this.cpfCliTxt.Location = new System.Drawing.Point(266, 180);
            this.cpfCliTxt.Name = "cpfCliTxt";
            this.cpfCliTxt.Size = new System.Drawing.Size(232, 20);
            this.cpfCliTxt.TabIndex = 45;
            // 
            // lblSubt
            // 
            this.lblSubt.AutoSize = true;
            this.lblSubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubt.Location = new System.Drawing.Point(21, 67);
            this.lblSubt.Name = "lblSubt";
            this.lblSubt.Size = new System.Drawing.Size(147, 24);
            this.lblSubt.TabIndex = 61;
            this.lblSubt.Text = "Cadastro Cliente";
            // 
            // lblTitl
            // 
            this.lblTitl.AutoSize = true;
            this.lblTitl.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitl.Location = new System.Drawing.Point(8, 19);
            this.lblTitl.Name = "lblTitl";
            this.lblTitl.Size = new System.Drawing.Size(196, 48);
            this.lblTitl.TabIndex = 60;
            this.lblTitl.Text = "California ";
            // 
            // cadCliBtn
            // 
            this.cadCliBtn.Location = new System.Drawing.Point(224, 347);
            this.cadCliBtn.Name = "cadCliBtn";
            this.cadCliBtn.Size = new System.Drawing.Size(313, 42);
            this.cadCliBtn.TabIndex = 62;
            this.cadCliBtn.Text = "Cadastrar";
            this.cadCliBtn.UseVisualStyleBackColor = true;
            this.cadCliBtn.Click += new System.EventHandler(this.CadCli_Click);
            // 
            // voltarCliLkn
            // 
            this.voltarCliLkn.AutoSize = true;
            this.voltarCliLkn.Location = new System.Drawing.Point(660, 392);
            this.voltarCliLkn.Name = "voltarCliLkn";
            this.voltarCliLkn.Size = new System.Drawing.Size(78, 13);
            this.voltarCliLkn.TabIndex = 63;
            this.voltarCliLkn.TabStop = true;
            this.voltarCliLkn.Text = "Voltar ao menu";
            this.voltarCliLkn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVoltarCli_LinkClicked);
            // 
            // telaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarCliLkn);
            this.Controls.Add(this.cadCliBtn);
            this.Controls.Add(this.lblSubt);
            this.Controls.Add(this.lblTitl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeCliTxt);
            this.Controls.Add(this.endCliTxt);
            this.Controls.Add(this.telefoneCliTxt);
            this.Controls.Add(this.cpfCliTxt);
            this.Name = "telaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeCliTxt;
        private System.Windows.Forms.TextBox endCliTxt;
        private System.Windows.Forms.TextBox telefoneCliTxt;
        private System.Windows.Forms.TextBox cpfCliTxt;
        private System.Windows.Forms.Label lblSubt;
        private System.Windows.Forms.Label lblTitl;
        private System.Windows.Forms.Button cadCliBtn;
        private System.Windows.Forms.LinkLabel voltarCliLkn;
    }
}

