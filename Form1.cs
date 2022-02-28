using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobrecargaMetodos_G2_2022_II
{
    public partial class Form1 : Form
    {
        private float suma;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            float operando1 =float.Parse( txtbOperando1.Text);
            float operando2 = float.Parse(txtbOperando2.Text);
            suma = operando1 + operando2;
            lbSuma.Text = suma.ToString();

        }
    }
}
