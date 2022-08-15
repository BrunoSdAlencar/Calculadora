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
        }
    }
}
