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
    public partial class frmcidadania : Form
    {
        public frmcidadania()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            double codigo, cidadania, lingua;

            codigo = Convert.ToDouble(txtcodigo.Text);

            if (codigo == 1)
            {
                txtcidadania.Text = "Brasileira";
                txtlingua.Text = "Portugues";
            }
            else if (codigo == 2)
            {
                txtcidadania.Text = "Alemã";
                txtlingua.Text = "Alemão";
            }
            else if (codigo == 3)
            {
                txtcidadania.Text = "Inglesa";
                txtlingua.Text = "Inglês";
            }
            else if (codigo == 4) 
            {
                txtcidadania.Text = "Italiana";
                txtlingua.Text = "Italiano";
            }
            else if (codigo == 5) 
            {
                txtcidadania.Text = "Espanhola";
                txtlingua.Text = "Espanhol";
            }
            else if (codigo == 6)
            {
                txtcidadania.Text = "Francesa";
                txtlingua.Text = "Francês";
            }
            else
            {
                txtcidadania.Text = "A cidadania em questão, não pode ser verificada";
                txtlingua.Text = "A língua nativa em questão, não pode ser verificada";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtcodigo.Focus();
            txtcidadania.Clear();
            txtlingua.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprojetos desc = new frmprojetos();
            desc.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
