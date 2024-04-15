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
    public partial class formnumero : Form
    {
        public formnumero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            num1 = Convert.ToDouble(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);
            result = num1 + num2;

            txtresultado.Text = result.ToString();
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtresultado.Clear();
            txtnumero1.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 desc = new Form3();
            desc.Show();
        }
    }
}
