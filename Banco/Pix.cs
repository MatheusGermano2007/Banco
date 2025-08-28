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
    public partial class Pix : Form
    {
        private Lancamento lancamento;
        private Lancamento pix; // Corrigido: tipo Lancamento

        public DateTime DataHoraLancamento { get; }

        public Pix()
        {
            InitializeComponent();
            lancamento = new Lancamento();
            pix = new Lancamento(); // Inicializa pix corretamente
            DataHoraLancamento = DateTime.Now;
        }

  
        private void txtPessoa_TextChanged(object sender, EventArgs e)
        {
            pix.Pessoa = txtPessoa.Text;
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
            pix.Mensagem = txtMensagem.Text;
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTipo.Text) && txtTipo.Text.Length == 1)
            {
                try
                {
                    pix.TipoLancamento = Convert.ToChar(txtTipo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tipo de lançamento inválido. Use 'D' para débito ou 'C' para crédito." +
                                    "\n\nMais detalhes:" + ex.Message,
                                    "Erro no Tipo de Lançamento",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                pix.DataHoraLancamento = DateTime.Now; // <<< aqui!
                string comprovante = pix.ComprovantePix();
                MessageBox.Show("Lançamento efetuado com sucesso!"
                                + "\n\nDetalhes do Lançamento:"
                                + comprovante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o lançamento!"
                                + "\n\nMais detalhes:" + ex.Message,
                                "Erro no Lançamento",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numUpValor_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numUpValor.Value;
            pix.ValorLancamento = value;
        }


    }
}
