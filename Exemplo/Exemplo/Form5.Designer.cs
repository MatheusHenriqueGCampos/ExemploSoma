namespace Exemplo
{
    partial class frmfatoral
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(58, 41);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(94, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Digite um Número:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(94, 76);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(58, 13);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Resultado:";
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(152, 310);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 23);
            this.btnwhile.TabIndex = 2;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndo
            // 
            this.btndo.Location = new System.Drawing.Point(291, 310);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(75, 23);
            this.btndo.TabIndex = 3;
            this.btndo.Text = "Do While";
            this.btndo.UseVisualStyleBackColor = true;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(439, 310);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 23);
            this.btnfor.TabIndex = 4;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(152, 378);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(439, 378);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(158, 38);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 7;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(158, 73);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(100, 56);
            this.txtresult.TabIndex = 8;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(291, 378);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // frmfatoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnumero);
            this.Name = "frmfatoral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnvoltar;
    }
}