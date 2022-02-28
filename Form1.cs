﻿using System;
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
        #region Eventos
        private void btnSuma_Click(object sender, EventArgs e)
        {
            float operando1 =float.Parse( txtbOperando1.Text);
            float operando2 = float.Parse(txtbOperando2.Text);
            /* suma = operando1 + operando2;
             lbSuma.Text = suma.ToString();
            */
            Sumar(operando1, operando2);

        }

        private void btnSuma2_Click(object sender, EventArgs e)
        {
            float operando1 = float.Parse(txtbOperando12.Text);
            float operando2 = float.Parse(txtbOpernado22.Text);
            float operando3 = float.Parse(txtbOperando23.Text);
            Sumar(operando1, operando2, operando3);

        }
        private void btnSuma3_Click(object sender, EventArgs e)
        {
            float operando1 = float.Parse(txtbOperando13.Text);
            float operando2 = float.Parse(txtbOperando32.Text);
            float operando3 = float.Parse(txtbOperando33.Text);
            float operando4 = float.Parse(txtbOperando43.Text);
            Sumar(operando1, operando2, operando3, operando4);
        }
        #endregion


        #region Métodos Sobrecargados
        public void Sumar(float sumando1, float sumando2)
        {
            suma = sumando1 + sumando2;
            lbSuma.Text = suma.ToString();

        }
        public void Sumar(float sumando1, float sumando2, float sumando3)
        {
            suma = sumando1 + sumando2 + sumando3;
            lbSuma2.Text = suma.ToString();
        }
        public void Sumar(float sumando1, float sumando2, float sumando3, float sumando4)
        {
            suma = sumando1 + sumando2 + sumando3 + sumando4;
            lbSuma3.Text = suma.ToString();
        }
        #endregion

    }
}
