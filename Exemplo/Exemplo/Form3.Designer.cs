namespace Exemplo
{
    partial class frmprojetos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsair = new System.Windows.Forms.Button();
            this.fatoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descontoToolStripMenuItem,
            this.somaToolStripMenuItem,
            this.cidadaniaToolStripMenuItem,
            this.fatoralToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projetosToolStripMenuItem.Text = "Projetos";
            // 
            // descontoToolStripMenuItem
            // 
            this.descontoToolStripMenuItem.Name = "descontoToolStripMenuItem";
            this.descontoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descontoToolStripMenuItem.Text = "Desconto";
            this.descontoToolStripMenuItem.Click += new System.EventHandler(this.descontoToolStripMenuItem_Click);
            // 
            // somaToolStripMenuItem
            // 
            this.somaToolStripMenuItem.Name = "somaToolStripMenuItem";
            this.somaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.somaToolStripMenuItem.Text = "Soma";
            this.somaToolStripMenuItem.Click += new System.EventHandler(this.somaToolStripMenuItem_Click);
            // 
            // cidadaniaToolStripMenuItem
            // 
            this.cidadaniaToolStripMenuItem.Name = "cidadaniaToolStripMenuItem";
            this.cidadaniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadaniaToolStripMenuItem.Text = "Cidadania";
            this.cidadaniaToolStripMenuItem.Click += new System.EventHandler(this.cidadaniaToolStripMenuItem_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(677, 389);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // fatoralToolStripMenuItem
            // 
            this.fatoralToolStripMenuItem.Name = "fatoralToolStripMenuItem";
            this.fatoralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fatoralToolStripMenuItem.Text = "Fatoral";
            this.fatoralToolStripMenuItem.Click += new System.EventHandler(this.fatoralToolStripMenuItem_Click);
            // 
            // frmprojetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprojetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaToolStripMenuItem;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.ToolStripMenuItem cidadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatoralToolStripMenuItem;
    }
}