using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteUmDcl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BonusTotal = int.Parse(txtValorVendas.Text) * 0.05; // 5% Valor Venda 
            var ComissaoTotal = int.Parse(txtCarrosVendidos.Text) * int.Parse(txtValorComissao.Text); // commissão para cada carro vendido
            var SalarioTotal = int.Parse(txtSalarioFixo.Text) + ComissaoTotal + BonusTotal;

            lblBonusMensal.Text = BonusTotal.ToString();
            lblComissao.Text = ComissaoTotal.ToString();
            lblSalarioFinal.Text = SalarioTotal.ToString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
