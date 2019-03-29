using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOMATAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void automatas()
        {
            int n1;
            string Estado;


            if (string.IsNullOrEmpty(txt1.Text))
            {
                MessageBox.Show("Debe ingresar una entrada");
                return;
            }

            n1 = int.Parse(txt1.Text);


            if (n1 == 10)
            {
                Estado = "Aceptado Estado final: C";
                lblResul.Text = "Resultado: " + Estado +
                    "\n Entrada: " + txt1.Text;
                MessageBox.Show("" + lblResul.Text);
            }
            else if (n1 == 11 || n1 == 111)
            {
                Estado = "Rechazado Estado final: B";
                lblResul.Text = "Resultado: " + Estado +
                    "\n Entrada: " + txt1.Text;
                MessageBox.Show("" + lblResul.Text);
            }
            else if (n1 == 0)
            {
                Estado = "Rechazado Estado final: A";
                lblResul.Text = "Resultado: " + Estado +
                    "\n Entrada: " + txt1.Text;
                MessageBox.Show("" + lblResul.Text);
            }
            else if (n1 == 1 || n1 == 1111)
            {
                Estado = "Rechazado Estado final: B";
                lblResul.Text = "Resultado: " + Estado +
                    "\n Entrada: " + txt1.Text;
                MessageBox.Show("" + lblResul.Text);
            }
            else if (n1 == 11111 || n1 == 111111)
            {
                Estado = "Rechazado Estado final: B";
                lblResul.Text = "Resultado: " + Estado +
                    "\n Entrada: " + txt1.Text;
                MessageBox.Show("" + lblResul.Text);
            }

            else if (n1 >= 100)
            {
                Estado = "Aceptado Estado final: C";
                lblResul.Text = "Resultado: " + Estado +
                    "\n Entrada: " + txt1.Text;
                MessageBox.Show("" + lblResul.Text);
            }
        }
        void limpiar()
        {
            txt1.Clear();
            txt1.Focus();
        }


        private void btnfio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿QUIERES PASAR EL RESTO DE TU VIDA CONMIGO?");
            FormFio f = new FormFio();
            f.ShowDialog();
        }

        private void txt1_key(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 50 && e.KeyChar <= 255))
            {
                MessageBox.Show("Los metodos de entrada solo son: 1's ó 0's ");
                e.Handled = true;
                return;
            }
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            automatas();
            limpiar();

        }
    }
}
