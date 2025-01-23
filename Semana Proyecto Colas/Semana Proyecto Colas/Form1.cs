using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_Proyecto_Colas {
    public partial class Form1: Form {

        Cola c = new Cola();

        public Form1() {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender,EventArgs e) 
        {
            if (c.validarTexto(txtBoxNombre.Text))
            {
                c.Enqueue(txtBoxNombre.Text.Trim());
                listBoxNombre.Items.Add(txtBoxNombre.Text);
                c.Mostrar(listBoxNombre);
            }
            else {
                MessageBox.Show("DATO NO VALIDO");
            }
            txtBoxNombre.Clear();
        }

        private void btnDesencolar_Click_1(object sender,EventArgs e)
        {
            if (c.Dequeue()!=null) 
            {
                MessageBox.Show("Desapilado correctamente ");
                listBoxNombre.Items.Clear();
                c.Mostrar(listBoxNombre);
            }
            else {
                MessageBox.Show("LA COLA ESTA VACIA");
            }

        }
        private void btnVistazo_Click(object sender,EventArgs e) 
        {
            string prim = c.Peek();
            if (prim!=null) {
                MessageBox.Show("Primero "+prim);
               
            } else {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
        }

        private void btnElementos_Click(object sender,EventArgs e) 
        {

            MessageBox.Show("#Elementos: "+c.Count());
        }

        private void btnDestruir_Click(object sender,EventArgs e) 
        {
            c.Clear();
            listBoxNombre.Items.Clear();
        }
    }
}
