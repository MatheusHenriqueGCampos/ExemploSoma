using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class frmprojetos : Form
    {
        public frmprojetos()
        {
            InitializeComponent();
        }

        private void descontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdesconto desc = new frmdesconto();
            desc.Show();
            
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsoma desc = new frmsoma();
            desc.Show();
                

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cidadaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcidadania desc = new frmcidadania();
            desc.Show();
        }
    }
}
