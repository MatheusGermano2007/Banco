using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmCaixaEletronico : Form
    {
        public FrmCaixaEletronico()
        {
            InitializeComponent();
            Conta.Saldo = 5000;
            lblSaldo.Text = Conta.Saldo.ToString("C");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Conta.Sacar(numValorSaque.Value);
            lblSaldo.Text = Conta.Saldo.ToString("C");
            MessageBox.Show("Saque realizado com sucesso! Valor sacado: " + numValorSaque.Value.ToString("C"), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
