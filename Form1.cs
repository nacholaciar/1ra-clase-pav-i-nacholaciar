using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textNombre.Text + " " + textApellido);
        }

        private void agregarPersona_Click(object sender, EventArgs e)
        {
            string nombreCompleto = "";
            nombreCompleto = textNombre.Text + " " + textApellido.Text;
            textPersonas.Items.Add(nombreCompleto);

            MessageBox.Show("persona agregada con exito");


        }
        private void LimpiarCampos()
        {
            textNombre.Text = "";
            textApellido.Text = "";
        }

    }
}
