
namespace california.e.UI
{
    partial class telaEstoque
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValProdTxt = new System.Windows.Forms.TextBox();
            this.ctgProdTxt = new System.Windows.Forms.TextBox();
            this.QuantProdTxt = new System.Windows.Forms.TextBox();
            this.NomeProdTxt = new System.Windows.Forms.TextBox();
            this.voltarLkn = new System.Windows.Forms.LinkLabel();
            this.tamanhoProdTxt = new System.Windows.Forms.TextBox();
            this.corProdTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pqsProdBtn = new System.Windows.Forms.Button();
            this.pqsProdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delBtnProd = new System.Windows.Forms.Button();
            this.canBtnProd = new System.Windows.Forms.Button();
            this.infoFunclbl = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.cadProd = new System.Windows.Forms.Button();
            this.lblSubtFunc = new System.Windows.Forms.Label();
            this.codprodlbl = new System.Windows.Forms.Label();
            this.codProdTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Categoria do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, -6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 48);
            this.label4.TabIndex = 26;
            this.label4.Text = "California ";
            // 
            // ValProdTxt
            // 
            this.ValProdTxt.Location = new System.Drawing.Point(51, 374);
            this.ValProdTxt.Name = "ValProdTxt";
            this.ValProdTxt.Size = new System.Drawing.Size(151, 20);
            this.ValProdTxt.TabIndex = 7;
            // 
            // ctgProdTxt
            // 
            this.ctgProdTxt.Location = new System.Drawing.Point(51, 296);
            this.ctgProdTxt.Name = "ctgProdTxt";
            this.ctgProdTxt.Size = new System.Drawing.Size(151, 20);
            this.ctgProdTxt.TabIndex = 5;
            // 
            // QuantProdTxt
            // 
            this.QuantProdTxt.Location = new System.Drawing.Point(48, 252);
            this.QuantProdTxt.Name = "QuantProdTxt";
            this.QuantProdTxt.Size = new System.Drawing.Size(154, 20);
            this.QuantProdTxt.TabIndex = 4;
            // 
            // NomeProdTxt
            // 
            this.NomeProdTxt.Location = new System.Drawing.Point(51, 335);
            this.NomeProdTxt.Name = "NomeProdTxt";
            this.NomeProdTxt.Size = new System.Drawing.Size(154, 20);
            this.NomeProdTxt.TabIndex = 6;
            // 
            // voltarLkn
            // 
            this.voltarLkn.AutoSize = true;
            this.voltarLkn.Location = new System.Drawing.Point(667, 406);
            this.voltarLkn.Name = "voltarLkn";
            this.voltarLkn.Size = new System.Drawing.Size(78, 13);
            this.voltarLkn.TabIndex = 37;
            this.voltarLkn.TabStop = true;
            this.voltarLkn.Text = "Voltar ao menu";
            this.voltarLkn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVoltar_LinkClicked);
            // 
            // tamanhoProdTxt
            // 
            this.tamanhoProdTxt.Location = new System.Drawing.Point(51, 169);
            this.tamanhoProdTxt.Name = "tamanhoProdTxt";
            this.tamanhoProdTxt.Size = new System.Drawing.Size(151, 20);
            this.tamanhoProdTxt.TabIndex = 2;
            // 
            // corProdTxt
            // 
            this.corProdTxt.Location = new System.Drawing.Point(51, 206);
            this.corProdTxt.Name = "corProdTxt";
            this.corProdTxt.Size = new System.Drawing.Size(151, 20);
            this.corProdTxt.TabIndex = 3;
            this.corProdTxt.TextChanged += new System.EventHandler(this.corProdTxt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Tamanho";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Cor";
            // 
            // pqsProdBtn
            // 
            this.pqsProdBtn.Location = new System.Drawing.Point(651, 97);
            this.pqsProdBtn.Name = "pqsProdBtn";
            this.pqsProdBtn.Size = new System.Drawing.Size(106, 24);
            this.pqsProdBtn.TabIndex = 84;
            this.pqsProdBtn.Text = "pesquisar";
            this.pqsProdBtn.UseVisualStyleBackColor = true;
            this.pqsProdBtn.Click += new System.EventHandler(this.pqsProdBtn_Click);
            // 
            // pqsProdTxt
            // 
            this.pqsProdTxt.Location = new System.Drawing.Point(408, 98);
            this.pqsProdTxt.Name = "pqsProdTxt";
            this.pqsProdTxt.Size = new System.Drawing.Size(237, 20);
            this.pqsProdTxt.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Nome";
            // 
            // delBtnProd
            // 
            this.delBtnProd.Location = new System.Drawing.Point(666, 344);
            this.delBtnProd.Name = "delBtnProd";
            this.delBtnProd.Size = new System.Drawing.Size(91, 24);
            this.delBtnProd.TabIndex = 81;
            this.delBtnProd.Text = "Deletar";
            this.delBtnProd.UseVisualStyleBackColor = true;
            this.delBtnProd.Click += new System.EventHandler(this.delBtnProd_Click);
            // 
            // canBtnProd
            // 
            this.canBtnProd.Location = new System.Drawing.Point(353, 374);
            this.canBtnProd.Name = "canBtnProd";
            this.canBtnProd.Size = new System.Drawing.Size(106, 24);
            this.canBtnProd.TabIndex = 80;
            this.canBtnProd.Text = "Cancelar";
            this.canBtnProd.UseVisualStyleBackColor = true;
            this.canBtnProd.Click += new System.EventHandler(this.canBtnProd_Click);
            // 
            // infoFunclbl
            // 
            this.infoFunclbl.AutoSize = true;
            this.infoFunclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFunclbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.infoFunclbl.Location = new System.Drawing.Point(566, 66);
            this.infoFunclbl.Name = "infoFunclbl";
            this.infoFunclbl.Size = new System.Drawing.Size(0, 18);
            this.infoFunclbl.TabIndex = 79;
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(353, 121);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(404, 214);
            this.dgvProd.TabIndex = 78;
            this.dgvProd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentDoubleClick);
            // 
            // cadProd
            // 
            this.cadProd.Location = new System.Drawing.Point(353, 344);
            this.cadProd.Name = "cadProd";
            this.cadProd.Size = new System.Drawing.Size(186, 24);
            this.cadProd.TabIndex = 8;
            this.cadProd.Text = "Salvar";
            this.cadProd.UseVisualStyleBackColor = true;
            this.cadProd.Click += new System.EventHandler(this.cadProd_Click);
            // 
            // lblSubtFunc
            // 
            this.lblSubtFunc.AutoSize = true;
            this.lblSubtFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtFunc.Location = new System.Drawing.Point(348, 61);
            this.lblSubtFunc.Name = "lblSubtFunc";
            this.lblSubtFunc.Size = new System.Drawing.Size(197, 25);
            this.lblSubtFunc.TabIndex = 76;
            this.lblSubtFunc.Text = "Registrar Produto";
            // 
            // codprodlbl
            // 
            this.codprodlbl.AutoSize = true;
            this.codprodlbl.Location = new System.Drawing.Point(48, 114);
            this.codprodlbl.Name = "codprodlbl";
            this.codprodlbl.Size = new System.Drawing.Size(39, 13);
            this.codprodlbl.TabIndex = 87;
            this.codprodlbl.Text = "código";
            // 
            // codProdTxt
            // 
            this.codProdTxt.Location = new System.Drawing.Point(48, 130);
            this.codProdTxt.Name = "codProdTxt";
            this.codProdTxt.Size = new System.Drawing.Size(151, 20);
            this.codProdTxt.TabIndex = 1;
            // 
            // telaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codprodlbl);
            this.Controls.Add(this.codProdTxt);
            this.Controls.Add(this.pqsProdBtn);
            this.Controls.Add(this.pqsProdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delBtnProd);
            this.Controls.Add(this.canBtnProd);
            this.Controls.Add(this.infoFunclbl);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.cadProd);
            this.Controls.Add(this.lblSubtFunc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.corProdTxt);
            this.Controls.Add(this.tamanhoProdTxt);
            this.Controls.Add(this.voltarLkn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValProdTxt);
            this.Controls.Add(this.ctgProdTxt);
            this.Controls.Add(this.QuantProdTxt);
            this.Controls.Add(this.NomeProdTxt);
            this.Name = "telaEstoque";
            this.Text = "telaEstoque";
            this.Load += new System.EventHandler(this.telaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValProdTxt;
        private System.Windows.Forms.TextBox ctgProdTxt;
        private System.Windows.Forms.TextBox QuantProdTxt;
        private System.Windows.Forms.TextBox NomeProdTxt;
        private System.Windows.Forms.LinkLabel voltarLkn;
        private System.Windows.Forms.TextBox tamanhoProdTxt;
        private System.Windows.Forms.TextBox corProdTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button pqsProdBtn;
        private System.Windows.Forms.TextBox pqsProdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delBtnProd;
        private System.Windows.Forms.Button canBtnProd;
        private System.Windows.Forms.Label infoFunclbl;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button cadProd;
        private System.Windows.Forms.Label lblSubtFunc;
        private System.Windows.Forms.Label codprodlbl;
        private System.Windows.Forms.TextBox codProdTxt;
    }
}