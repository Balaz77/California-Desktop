
namespace california.e.UI
{
    partial class telaLogin
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
            this.cadFunLkn = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.logEnterBtn = new System.Windows.Forms.Button();
            this.logPwdLbl = new System.Windows.Forms.Label();
            this.logUserLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logPwdTxt = new System.Windows.Forms.TextBox();
            this.logUserTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadFunLkn
            // 
            this.cadFunLkn.AutoSize = true;
            this.cadFunLkn.Location = new System.Drawing.Point(417, 401);
            this.cadFunLkn.Name = "cadFunLkn";
            this.cadFunLkn.Size = new System.Drawing.Size(66, 13);
            this.cadFunLkn.TabIndex = 15;
            this.cadFunLkn.TabStop = true;
            this.cadFunLkn.Text = "Cadastre-se!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "California ";
            // 
            // logEnterBtn
            // 
            this.logEnterBtn.Location = new System.Drawing.Point(340, 334);
            this.logEnterBtn.Name = "logEnterBtn";
            this.logEnterBtn.Size = new System.Drawing.Size(121, 37);
            this.logEnterBtn.TabIndex = 13;
            this.logEnterBtn.Text = "Entrar";
            this.logEnterBtn.UseVisualStyleBackColor = true;
            this.logEnterBtn.Click += new System.EventHandler(this.EnterUser_Click);
            // 
            // logPwdLbl
            // 
            this.logPwdLbl.AutoSize = true;
            this.logPwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPwdLbl.Location = new System.Drawing.Point(305, 235);
            this.logPwdLbl.Name = "logPwdLbl";
            this.logPwdLbl.Size = new System.Drawing.Size(50, 18);
            this.logPwdLbl.TabIndex = 12;
            this.logPwdLbl.Text = "Senha";
            // 
            // logUserLbl
            // 
            this.logUserLbl.AutoSize = true;
            this.logUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logUserLbl.Location = new System.Drawing.Point(305, 159);
            this.logUserLbl.Name = "logUserLbl";
            this.logUserLbl.Size = new System.Drawing.Size(60, 18);
            this.logUserLbl.TabIndex = 11;
            this.logUserLbl.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // logPwdTxt
            // 
            this.logPwdTxt.Location = new System.Drawing.Point(308, 256);
            this.logPwdTxt.Name = "logPwdTxt";
            this.logPwdTxt.Size = new System.Drawing.Size(193, 20);
            this.logPwdTxt.TabIndex = 9;
            // 
            // logUserTxt
            // 
            this.logUserTxt.Location = new System.Drawing.Point(308, 180);
            this.logUserTxt.Name = "logUserTxt";
            this.logUserTxt.Size = new System.Drawing.Size(193, 20);
            this.logUserTxt.TabIndex = 8;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadFunLkn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logEnterBtn);
            this.Controls.Add(this.logPwdLbl);
            this.Controls.Add(this.logUserLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logPwdTxt);
            this.Controls.Add(this.logUserTxt);
            this.Name = "telaLogin";
            this.Text = "telaLogin";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel cadFunLkn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logEnterBtn;
        private System.Windows.Forms.Label logPwdLbl;
        private System.Windows.Forms.Label logUserLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logPwdTxt;
        private System.Windows.Forms.TextBox logUserTxt;
    }
}