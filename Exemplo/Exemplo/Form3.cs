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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void descontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 desc = new Form2();
            desc.Show();
            
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formnumero desc = new formnumero();
            desc.Show();
                

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
