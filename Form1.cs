using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste2DCL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Total = 0;
            var valorFracao = decimal.Parse(txtValorMinuto.Text) / 10;

            if (int.Parse(txtDuracaoSegundos.Text) <= 60)
            {
                Total = decimal.Parse(txtValorMinuto.Text);
            }
            else
            {
                for (int i = 60; i <= int.Parse(txtDuracaoSegundos.Text); i++)
                {
                    if (i % 6 == 0)
                    {
                        Total += valorFracao;
                    }
                    
                }
                Total += decimal.Parse(txtValorMinuto.Text);
            }

            lblTotalValor.Text = Total.ToString();
        }
    }
}
