namespace Exemplo
{
    partial class Form2
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
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblregiao = new System.Windows.Forms.Label();
            this.txtregiao = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(13, 13);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(93, 13);
            this.lblpreco.TabIndex = 0;
            this.lblpreco.Text = "Preço do Produto:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(13, 60);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(82, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Digite o Código:";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(12, 111);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(161, 13);
            this.lbldesconto.TabIndex = 2;
            this.lbldesconto.Text = "Valor do Produto com Desconto:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(122, 10);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(113, 57);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Enabled = false;
            this.txtdesconto.Location = new System.Drawing.Point(189, 108);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.ReadOnly = true;
            this.txtdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtdesconto.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(63, 263);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(246, 263);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(573, 263);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblregiao
            // 
            this.lblregiao.AutoSize = true;
            this.lblregiao.Location = new System.Drawing.Point(13, 165);
            this.lblregiao.Name = "lblregiao";
            this.lblregiao.Size = new System.Drawing.Size(44, 13);
            this.lblregiao.TabIndex = 9;
            this.lblregiao.Text = "Região:";
            // 
            // txtregiao
            // 
            this.txtregiao.Enabled = false;
            this.txtregiao.Location = new System.Drawing.Point(73, 162);
            this.txtregiao.Name = "txtregiao";
            this.txtregiao.ReadOnly = true;
            this.txtregiao.Size = new System.Drawing.Size(149, 20);
            this.txtregiao.TabIndex = 10;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(408, 263);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtregiao);
            this.Controls.Add(this.lblregiao);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblpreco);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblregiao;
        private System.Windows.Forms.TextBox txtregiao;
        private System.Windows.Forms.Button btnvoltar;
    }
}