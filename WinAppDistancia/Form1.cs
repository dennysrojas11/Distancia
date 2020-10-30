using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDistancia
{
    public partial class Form1 : Form
    {
        private TextBox[] textboxs;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxX1.Focus();
            labelResultado.Visible = false;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textboxs = new TextBox[] { textBoxX1, textBoxX2, textBoxY1, textBoxY2 };
            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));

            if (datosCorrectos)
            {
                Distancia d = new Distancia(double.Parse(textBoxX1.Text), double.Parse(textBoxY1.Text), double.Parse(textBoxX2.Text), double.Parse(textBoxY2.Text));
                labelResultado.Text = d.calcular().ToString();
                labelResultado.Visible = true;
                textBoxX1.Focus();
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Campos incompletos",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxY2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxY1.Focus();
            }
            Validar.validar(e);

        }

        private void textBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxX2.Focus();
            }
            Validar.validar(e);
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxY2.Focus();
            }
            Validar.validar(e);
        }

        private void textBoxY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonCalcular.Focus();
            }
            Validar.validar(e);
        }

        private void groupBoxPunto1_Enter(object sender, EventArgs e)
        {

        }
    }
}