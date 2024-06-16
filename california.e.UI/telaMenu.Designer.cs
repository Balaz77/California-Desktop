
namespace california.e.UI
{
    partial class telaMenu
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
            this.estoqueBtn = new System.Windows.Forms.Button();
            this.vendasBtn = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.cadCliBtn = new System.Windows.Forms.Button();
            this.cadFunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estoqueBtn
            // 
            this.estoqueBtn.Location = new System.Drawing.Point(48, 86);
            this.estoqueBtn.Name = "estoqueBtn";
            this.estoqueBtn.Size = new System.Drawing.Size(205, 79);
            this.estoqueBtn.TabIndex = 1;
            this.estoqueBtn.Text = "Estoque";
            this.estoqueBtn.UseVisualStyleBackColor = true;
            this.estoqueBtn.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // vendasBtn
            // 
            this.vendasBtn.Location = new System.Drawing.Point(292, 86);
            this.vendasBtn.Name = "vendasBtn";
            this.vendasBtn.Size = new System.Drawing.Size(205, 79);
            this.vendasBtn.TabIndex = 3;
            this.vendasBtn.Text = "Vendas";
            this.vendasBtn.UseVisualStyleBackColor = true;
            this.vendasBtn.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(531, 86);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(205, 79);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // cadCliBtn
            // 
            this.cadCliBtn.Location = new System.Drawing.Point(425, 297);
            this.cadCliBtn.Name = "cadCliBtn";
            this.cadCliBtn.Size = new System.Drawing.Size(205, 79);
            this.cadCliBtn.TabIndex = 5;
            this.cadCliBtn.Text = "Cadastrar cliente";
            this.cadCliBtn.UseVisualStyleBackColor = true;
            this.cadCliBtn.Click += new System.EventHandler(this.btnCadcli_Click);
            // 
            // cadFunBtn
            // 
            this.cadFunBtn.Location = new System.Drawing.Point(166, 297);
            this.cadFunBtn.Name = "cadFunBtn";
            this.cadFunBtn.Size = new System.Drawing.Size(205, 79);
            this.cadFunBtn.TabIndex = 6;
            this.cadFunBtn.Text = "Cadastrar funcionario";
            this.cadFunBtn.UseVisualStyleBackColor = true;
            this.cadFunBtn.Click += new System.EventHandler(this.btnCadfun_Click);
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadFunBtn);
            this.Controls.Add(this.cadCliBtn);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.vendasBtn);
            this.Controls.Add(this.estoqueBtn);
            this.Name = "telaMenu";
            this.Text = "telaMenu";
            this.Load += new System.EventHandler(this.telaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button estoqueBtn;
        private System.Windows.Forms.Button vendasBtn;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button cadCliBtn;
        private System.Windows.Forms.Button cadFunBtn;
    }
}