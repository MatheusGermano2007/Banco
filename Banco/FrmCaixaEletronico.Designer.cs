namespace Banco
{
    partial class FrmCaixaEletronico
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
            this.btnSacar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.numValorSaque = new System.Windows.Forms.NumericUpDown();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numValorDeposito = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(18, 262);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(107, 39);
            this.btnSacar.TabIndex = 0;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(317, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Saque:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(405, 55);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(177, 39);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numValorSaque
            // 
            this.numValorSaque.Location = new System.Drawing.Point(153, 127);
            this.numValorSaque.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numValorSaque.Name = "numValorSaque";
            this.numValorSaque.Size = new System.Drawing.Size(120, 20);
            this.numValorSaque.TabIndex = 4;
            this.numValorSaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(507, 264);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 37);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(166, 262);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(107, 39);
            this.btnDepositar.TabIndex = 6;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Deposito:";
            // 
            // numValorDeposito
            // 
            this.numValorDeposito.Location = new System.Drawing.Point(153, 64);
            this.numValorDeposito.Name = "numValorDeposito";
            this.numValorDeposito.Size = new System.Drawing.Size(120, 20);
            this.numValorDeposito.TabIndex = 8;
            this.numValorDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "LimiteCredito:";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCredito.Location = new System.Drawing.Point(149, 192);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(124, 20);
            this.lblLimiteCredito.TabIndex = 10;
            this.lblLimiteCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(587, 308);
            this.Controls.Add(this.lblLimiteCredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numValorDeposito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.numValorSaque);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSacar);
            this.Name = "FrmCaixaEletronico";
            this.Text = "CaixaEletronico";
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.NumericUpDown numValorSaque;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numValorDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLimiteCredito;
    }
}

