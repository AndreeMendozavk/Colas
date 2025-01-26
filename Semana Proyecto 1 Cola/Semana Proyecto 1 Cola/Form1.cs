using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Proyecto_1_Cola
{
    public partial class Form1 : Form
    {
        Cola c = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {

            if (c.validarTexto(txtBoxNombres.Text))
            {
                c.Enqueue(txtBoxNombres.Text.Trim());
                listBoxNombres.Items.Add(txtBoxNombres.Text);
                listBoxNombres.Items.Clear();
                c.Mostrar(listBoxNombres);
            }
            else
            {
                MessageBox.Show("DATO NO VALIDO");
            }
            txtBoxNombres.Clear();

        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if(c.Dequeue() != null)
            {
                MessageBox.Show("Desapilado correctamente ");
                listBoxNombres.Items.Clear();
                c.Mostrar(listBoxNombres);
            }
            else
            {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
           string prim = c.Peek();
            if (prim != null)
            {
                MessageBox.Show("Primero " + prim);

            }
            else
            {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" #Elementos: " + c.Count());
        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
            c.Clear();
            listBoxNombres.Items.Clear();

        }
    }
}
