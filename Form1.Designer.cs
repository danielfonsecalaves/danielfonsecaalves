namespace TesteUmDcl
{
    partial class Form1
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
            this.txtCarrosVendidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorVendas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioFixo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorComissao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSalarioFinal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBonusMensal = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCarrosVendidos
            // 
            this.txtCarrosVendidos.Location = new System.Drawing.Point(170, 64);
            this.txtCarrosVendidos.Name = "txtCarrosVendidos";
            this.txtCarrosVendidos.Size = new System.Drawing.Size(100, 22);
            this.txtCarrosVendidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Carros Vendidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Revenda de carros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Total Vendas:";
            // 
            // txtValorVendas
            // 
            this.txtValorVendas.Location = new System.Drawing.Point(170, 92);
            this.txtValorVendas.Name = "txtValorVendas";
            this.txtValorVendas.Size = new System.Drawing.Size(100, 22);
            this.txtValorVendas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário Fixo:";
            // 
            // txtSalarioFixo
            // 
            this.txtSalarioFixo.Location = new System.Drawing.Point(170, 120);
            this.txtSalarioFixo.Name = "txtSalarioFixo";
            this.txtSalarioFixo.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioFixo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Comissão:";
            // 
            // txtValorComissao
            // 
            this.txtValorComissao.Location = new System.Drawing.Point(170, 148);
            this.txtValorComissao.Name = "txtValorComissao";
            this.txtValorComissao.Size = new System.Drawing.Size(100, 22);
            this.txtValorComissao.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salário Final:";
            // 
            // lblSalarioFinal
            // 
            this.lblSalarioFinal.AutoSize = true;
            this.lblSalarioFinal.Location = new System.Drawing.Point(130, 276);
            this.lblSalarioFinal.Name = "lblSalarioFinal";
            this.lblSalarioFinal.Size = new System.Drawing.Size(13, 17);
            this.lblSalarioFinal.TabIndex = 11;
            this.lblSalarioFinal.Text = "-";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(142, 191);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bônus Mensal:";
            // 
            // lblBonusMensal
            // 
            this.lblBonusMensal.AutoSize = true;
            this.lblBonusMensal.Location = new System.Drawing.Point(130, 231);
            this.lblBonusMensal.Name = "lblBonusMensal";
            this.lblBonusMensal.Size = new System.Drawing.Size(13, 17);
            this.lblBonusMensal.TabIndex = 14;
            this.lblBonusMensal.Text = "-";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(130, 253);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(13, 17);
            this.lblComissao.TabIndex = 16;
            this.lblComissao.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Comissão:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 302);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBonusMensal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblSalarioFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorComissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalarioFixo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarrosVendidos);
            this.Name = "Form1";
            this.Text = "Cálculo Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarrosVendidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioFixo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorComissao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalarioFinal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBonusMensal;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.Label label9;
    }
}

