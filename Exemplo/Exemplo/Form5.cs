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
    public partial class frmfatoral : Form
    {
        public frmfatoral()
        {
            InitializeComponent();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double numero, result, i;

            numero = Convert.ToDouble(txtnumero.Text);
            i = numero;
            result = numero;
            while (i> 2)
            {
                i--;
                result = result * i;
                txtresult.Text = string.Concat(txtresult.Text, "\r\n", result.ToString());
            }
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            double numero, result, i;

            numero = Convert.ToDouble(txtnumero.Text);
            i = numero;
            result = numero;
            do
            {
                i--;
                result = result * i;
                txtresult.Text = string.Concat(txtresult.Text, "\r\n", result.ToString());
            } while (i > 2);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double numero, result, i;
        }
    }
}
