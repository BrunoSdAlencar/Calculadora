using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operador;
        int a = 0;
        bool validar = false;

        public Form1() {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e) {
            Button bt = (Button)sender;
            txtvalor.Text = txtvalor.Text + bt.Text;
        }

        private void btlimpar_Click(object sender, EventArgs e) {
            txtvalor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btsom_Click(object sender, EventArgs e) {
            if(validar == true) {
                a = a + Convert.ToInt32(txtvalor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtvalor.Text = "";
                operador = "+";
            } else {
                label1.Text = txtvalor.Text + btsom.Text;
                a = Convert.ToInt32(txtvalor.Text);
                txtvalor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btsub_Click(object sender, EventArgs e) {
            if (validar == true) {
                a = a - Convert.ToInt32(txtvalor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtvalor.Text = "";
                operador = "-";
            } else {
                label1.Text = txtvalor.Text + btsub.Text;
                a = Convert.ToInt32(txtvalor.Text);
                txtvalor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btmult_Click(object sender, EventArgs e) {
            if (validar == true) {
                a = a * Convert.ToInt32(txtvalor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtvalor.Text = "";
                operador = "*";
            } else {
                label1.Text = txtvalor.Text + btmult.Text;
                a = Convert.ToInt32(txtvalor.Text);
                txtvalor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btdiv_Click(object sender, EventArgs e) {
            if (validar == true) {
                a = a / Convert.ToInt32(txtvalor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtvalor.Text = "";
                operador = "/";
            } else {
                label1.Text = txtvalor.Text + btdiv.Text;
                a = Convert.ToInt32(txtvalor.Text);
                txtvalor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btigual_Click(object sender, EventArgs e) {
            if (operador=="+") {
                label1.Text = label1.Text + txtvalor.Text + "=";
                txtvalor.Text = Convert.ToString(a + Convert.ToInt32(txtvalor.Text));
            } else if (operador=="-") {
                label1.Text = label1.Text + txtvalor.Text + "=";
                txtvalor.Text = Convert.ToString(a - Convert.ToInt32(txtvalor.Text));
            } else if (operador=="*") {
                label1.Text = label1.Text + txtvalor.Text + "=";
                txtvalor.Text = Convert.ToString(a * Convert.ToInt32(txtvalor.Text));
            } else if (operador=="/") {
                label1.Text = label1.Text + txtvalor.Text + "=";
                txtvalor.Text = Convert.ToString(a / Convert.ToInt32(txtvalor.Text));
            }
        }
    }
}
