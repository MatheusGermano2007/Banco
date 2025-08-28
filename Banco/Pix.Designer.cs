namespace Banco
{
    partial class Pix
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.numUpValor = new System.Windows.Forms.NumericUpDown();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pessoa:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mensagem:";
            // 
            // txtPessoa
            // 
            this.txtPessoa.Location = new System.Drawing.Point(171, 163);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(245, 20);
            this.txtPessoa.TabIndex = 4;
            this.txtPessoa.TextChanged += new System.EventHandler(this.txtPessoa_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(171, 104);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(245, 20);
            this.txtTipo.TabIndex = 5;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(171, 223);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(245, 59);
            this.txtMensagem.TabIndex = 6;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // numUpValor
            // 
            this.numUpValor.Location = new System.Drawing.Point(171, 38);
            this.numUpValor.Name = "numUpValor";
            this.numUpValor.Size = new System.Drawing.Size(245, 20);
            this.numUpValor.TabIndex = 7;
            this.numUpValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpValor.ValueChanged += new System.EventHandler(this.numUpValor_ValueChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(227, 321);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(107, 64);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(454, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 32);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Pix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 452);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.numUpValor);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pix";
            this.Text = "Pix";
            ((System.ComponentModel.ISupportInitialize)(this.numUpValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.NumericUpDown numUpValor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSair;
    }
}