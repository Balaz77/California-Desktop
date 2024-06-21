
namespace california.e.UI
{
    partial class telaVendas
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
            this.regProdBtn = new System.Windows.Forms.Button();
            this.dtVendaLbl = new System.Windows.Forms.Label();
            this.nomeProdLbl = new System.Windows.Forms.Label();
            this.saleVendaLbl = new System.Windows.Forms.Label();
            this.qntVendaLbl = new System.Windows.Forms.Label();
            this.nomeProdTxt = new System.Windows.Forms.TextBox();
            this.dtVendaTxt = new System.Windows.Forms.TextBox();
            this.saleVendaTxt = new System.Windows.Forms.TextBox();
            this.qntVendaTxt = new System.Windows.Forms.TextBox();
            this.valVendaTxt = new System.Windows.Forms.TextBox();
            this.valVendaLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lklVoltarVnd = new System.Windows.Forms.LinkLabel();
            this.pqsProdBtn = new System.Windows.Forms.Button();
            this.pqsProdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canBtnProd = new System.Windows.Forms.Button();
            this.infoFunclbl = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // regProdBtn
            // 
            this.regProdBtn.Location = new System.Drawing.Point(312, 323);
            this.regProdBtn.Name = "regProdBtn";
            this.regProdBtn.Size = new System.Drawing.Size(193, 27);
            this.regProdBtn.TabIndex = 39;
            this.regProdBtn.Text = "Salvar";
            this.regProdBtn.UseVisualStyleBackColor = true;
            this.regProdBtn.Click += new System.EventHandler(this.regProdBtn_Click);
            // 
            // dtVendaLbl
            // 
            this.dtVendaLbl.AutoSize = true;
            this.dtVendaLbl.Location = new System.Drawing.Point(57, 340);
            this.dtVendaLbl.Name = "dtVendaLbl";
            this.dtVendaLbl.Size = new System.Drawing.Size(30, 13);
            this.dtVendaLbl.TabIndex = 38;
            this.dtVendaLbl.Text = "Data";
            // 
            // nomeProdLbl
            // 
            this.nomeProdLbl.AutoSize = true;
            this.nomeProdLbl.Location = new System.Drawing.Point(57, 293);
            this.nomeProdLbl.Name = "nomeProdLbl";
            this.nomeProdLbl.Size = new System.Drawing.Size(74, 13);
            this.nomeProdLbl.TabIndex = 36;
            this.nomeProdLbl.Text = "Nome produto";
            // 
            // saleVendaLbl
            // 
            this.saleVendaLbl.AutoSize = true;
            this.saleVendaLbl.Location = new System.Drawing.Point(57, 245);
            this.saleVendaLbl.Name = "saleVendaLbl";
            this.saleVendaLbl.Size = new System.Drawing.Size(134, 13);
            this.saleVendaLbl.TabIndex = 35;
            this.saleVendaLbl.Text = "inserir desconto na compra";
            // 
            // qntVendaLbl
            // 
            this.qntVendaLbl.AutoSize = true;
            this.qntVendaLbl.Location = new System.Drawing.Point(57, 199);
            this.qntVendaLbl.Name = "qntVendaLbl";
            this.qntVendaLbl.Size = new System.Drawing.Size(60, 13);
            this.qntVendaLbl.TabIndex = 34;
            this.qntVendaLbl.Text = "quantidade";
            // 
            // nomeProdTxt
            // 
            this.nomeProdTxt.Location = new System.Drawing.Point(60, 309);
            this.nomeProdTxt.Name = "nomeProdTxt";
            this.nomeProdTxt.Size = new System.Drawing.Size(130, 20);
            this.nomeProdTxt.TabIndex = 32;
            // 
            // dtVendaTxt
            // 
            this.dtVendaTxt.Location = new System.Drawing.Point(60, 356);
            this.dtVendaTxt.Name = "dtVendaTxt";
            this.dtVendaTxt.Size = new System.Drawing.Size(91, 20);
            this.dtVendaTxt.TabIndex = 31;
            // 
            // saleVendaTxt
            // 
            this.saleVendaTxt.Location = new System.Drawing.Point(60, 261);
            this.saleVendaTxt.Name = "saleVendaTxt";
            this.saleVendaTxt.Size = new System.Drawing.Size(131, 20);
            this.saleVendaTxt.TabIndex = 30;
            // 
            // qntVendaTxt
            // 
            this.qntVendaTxt.Location = new System.Drawing.Point(60, 213);
            this.qntVendaTxt.Name = "qntVendaTxt";
            this.qntVendaTxt.Size = new System.Drawing.Size(81, 20);
            this.qntVendaTxt.TabIndex = 29;
            // 
            // valVendaTxt
            // 
            this.valVendaTxt.Location = new System.Drawing.Point(60, 167);
            this.valVendaTxt.Name = "valVendaTxt";
            this.valVendaTxt.Size = new System.Drawing.Size(81, 20);
            this.valVendaTxt.TabIndex = 28;
            // 
            // valVendaLbl
            // 
            this.valVendaLbl.AutoSize = true;
            this.valVendaLbl.Location = new System.Drawing.Point(57, 151);
            this.valVendaLbl.Name = "valVendaLbl";
            this.valVendaLbl.Size = new System.Drawing.Size(84, 13);
            this.valVendaLbl.TabIndex = 27;
            this.valVendaLbl.Text = "Valor da compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Vendas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 48);
            this.label4.TabIndex = 40;
            this.label4.Text = "California ";
            // 
            // lklVoltarVnd
            // 
            this.lklVoltarVnd.AutoSize = true;
            this.lklVoltarVnd.Location = new System.Drawing.Point(663, 397);
            this.lklVoltarVnd.Name = "lklVoltarVnd";
            this.lklVoltarVnd.Size = new System.Drawing.Size(78, 13);
            this.lklVoltarVnd.TabIndex = 43;
            this.lklVoltarVnd.TabStop = true;
            this.lklVoltarVnd.Text = "Voltar ao menu";
            this.lklVoltarVnd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVoltar_LinkClicked);
            // 
            // pqsProdBtn
            // 
            this.pqsProdBtn.Location = new System.Drawing.Point(549, 77);
            this.pqsProdBtn.Name = "pqsProdBtn";
            this.pqsProdBtn.Size = new System.Drawing.Size(106, 24);
            this.pqsProdBtn.TabIndex = 84;
            this.pqsProdBtn.Text = "Pesquisar";
            this.pqsProdBtn.UseVisualStyleBackColor = true;
            this.pqsProdBtn.Click += new System.EventHandler(this.pqsProdBtn_Click);
            // 
            // pqsProdTxt
            // 
            this.pqsProdTxt.Location = new System.Drawing.Point(427, 80);
            this.pqsProdTxt.Name = "pqsProdTxt";
            this.pqsProdTxt.Size = new System.Drawing.Size(116, 20);
            this.pqsProdTxt.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Data da venda";
            // 
            // canBtnProd
            // 
            this.canBtnProd.Location = new System.Drawing.Point(312, 356);
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
            this.infoFunclbl.Location = new System.Drawing.Point(427, 48);
            this.infoFunclbl.Name = "infoFunclbl";
            this.infoFunclbl.Size = new System.Drawing.Size(0, 18);
            this.infoFunclbl.TabIndex = 79;
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(312, 103);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(429, 214);
            this.dgvProd.TabIndex = 78;
            this.dgvProd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Código da compra ";
            // 
            // telaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pqsProdBtn);
            this.Controls.Add(this.pqsProdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canBtnProd);
            this.Controls.Add(this.infoFunclbl);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.lklVoltarVnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regProdBtn);
            this.Controls.Add(this.dtVendaLbl);
            this.Controls.Add(this.nomeProdLbl);
            this.Controls.Add(this.saleVendaLbl);
            this.Controls.Add(this.qntVendaLbl);
            this.Controls.Add(this.nomeProdTxt);
            this.Controls.Add(this.dtVendaTxt);
            this.Controls.Add(this.saleVendaTxt);
            this.Controls.Add(this.qntVendaTxt);
            this.Controls.Add(this.valVendaTxt);
            this.Controls.Add(this.valVendaLbl);
            this.Name = "telaVendas";
            this.Text = "telaVendas";
            this.Load += new System.EventHandler(this.telaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regProdBtn;
        private System.Windows.Forms.Label dtVendaLbl;
        private System.Windows.Forms.Label nomeProdLbl;
        private System.Windows.Forms.Label saleVendaLbl;
        private System.Windows.Forms.Label qntVendaLbl;
        private System.Windows.Forms.TextBox nomeProdTxt;
        private System.Windows.Forms.TextBox dtVendaTxt;
        private System.Windows.Forms.TextBox saleVendaTxt;
        private System.Windows.Forms.TextBox qntVendaTxt;
        private System.Windows.Forms.TextBox valVendaTxt;
        private System.Windows.Forms.Label valVendaLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lklVoltarVnd;
        private System.Windows.Forms.Button pqsProdBtn;
        private System.Windows.Forms.TextBox pqsProdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button canBtnProd;
        private System.Windows.Forms.Label infoFunclbl;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}