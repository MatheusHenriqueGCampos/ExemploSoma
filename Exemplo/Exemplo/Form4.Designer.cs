namespace Exemplo
{
    partial class frmcidadania
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcidadania = new System.Windows.Forms.TextBox();
            this.lblcidadania = new System.Windows.Forms.Label();
            this.lbllingua = new System.Windows.Forms.Label();
            this.txtlingua = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(13, 13);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(165, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Digite o código da sua cidadania:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(184, 10);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtcidadania
            // 
            this.txtcidadania.Enabled = false;
            this.txtcidadania.Location = new System.Drawing.Point(76, 63);
            this.txtcidadania.Name = "txtcidadania";
            this.txtcidadania.ReadOnly = true;
            this.txtcidadania.Size = new System.Drawing.Size(242, 20);
            this.txtcidadania.TabIndex = 2;
            this.txtcidadania.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblcidadania
            // 
            this.lblcidadania.AutoSize = true;
            this.lblcidadania.Location = new System.Drawing.Point(13, 66);
            this.lblcidadania.Name = "lblcidadania";
            this.lblcidadania.Size = new System.Drawing.Size(57, 13);
            this.lblcidadania.TabIndex = 3;
            this.lblcidadania.Text = "Cidadania:";
            // 
            // lbllingua
            // 
            this.lbllingua.AutoSize = true;
            this.lbllingua.Location = new System.Drawing.Point(13, 131);
            this.lbllingua.Name = "lbllingua";
            this.lbllingua.Size = new System.Drawing.Size(76, 13);
            this.lbllingua.TabIndex = 4;
            this.lbllingua.Text = "Lingua Nativa:";
            // 
            // txtlingua
            // 
            this.txtlingua.Enabled = false;
            this.txtlingua.Location = new System.Drawing.Point(95, 128);
            this.txtlingua.Name = "txtlingua";
            this.txtlingua.ReadOnly = true;
            this.txtlingua.Size = new System.Drawing.Size(258, 20);
            this.txtlingua.TabIndex = 5;
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(83, 336);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 23);
            this.btnverificar.TabIndex = 6;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(257, 336);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(447, 336);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(621, 336);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmcidadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txtlingua);
            this.Controls.Add(this.lbllingua);
            this.Controls.Add(this.lblcidadania);
            this.Controls.Add(this.txtcidadania);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmcidadania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidadania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcidadania;
        private System.Windows.Forms.Label lblcidadania;
        private System.Windows.Forms.Label lbllingua;
        private System.Windows.Forms.TextBox txtlingua;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnsair;
    }
}