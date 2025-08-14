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
        private Conta conta;

        public FrmCaixaEletronico()
        {
            InitializeComponent();
            conta = new Conta(); 
            conta.Saldo = 5000;
            conta.LimiteCredito1 = 1000;
            lblSaldo.Text = conta.Saldo.ToString("C");
            lblLimiteCredito.Text = conta.LimiteCredito1.ToString("C");
        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {

                conta.Sacar(numValorSaque.Value);
                lblSaldo.Text = conta.Saldo.ToString("C");
                MessageBox.Show(
                    $"Saque realizado com sucesso!\nValor sacado: {numValorSaque.Value.ToString("C")}\nSaldo após saque: {conta.Saldo.ToString("C")}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Depositar(numValorDeposito.Value);
            lblSaldo.Text = conta.Saldo.ToString("C");
            MessageBox.Show(
                $"Depósito realizado com sucesso!\nValor depositado: {numValorDeposito.Value.ToString("C")}\nSaldo após Deposito: { conta.Saldo.ToString("C")}",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
