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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            FrmCaixaEletronico frmCaixa = new FrmCaixaEletronico();
            frmCaixa.Show();
            this.Hide();
        }

        private void btnSairInicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
