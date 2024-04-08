﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtdesconto.Clear();
            txtpreco.Clear();
            txtpreco.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco, codigo, descon;

            preco = Convert.ToDouble(txtpreco.Text);
            codigo = Convert.ToDouble(txtcodigo.Text);

            if (codigo == 1)
            {
               descon = preco - ((preco / 100) * 5);
               txtdesconto.Text = descon.ToString();
                txtregiao.Text = "Norte";
            }
            else if (codigo == 2)
            {
                descon = preco - ((preco / 100) * 15);
                txtdesconto.Text = descon.ToString();
                txtregiao.Text = "Sul";
            }
            else if (codigo == 3)
            {
                descon = preco - ((preco / 100) * 7);
                txtdesconto.Text = descon.ToString();
                txtregiao.Text = "Suldeste";
            }
            else if (codigo == 4)
            {
                descon = preco - ((preco / 100) * 12);
                txtdesconto.Text = descon.ToString();
                txtregiao.Text = "Nordeste";
            }
            else if (codigo == 5)
            {
                descon = preco - ((preco / 100) * 20);
                txtdesconto.Text = descon.ToString();
                txtregiao.Text = "Centro-Oeste";
            }

            
        }
    }
}