using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programFactFacultad
{
    public partial class listaDeVendedores : Form
    {
        public listaDeVendedores()
        {
            InitializeComponent();
        }

        private void listaDeVendedores_Load(object sender, EventArgs e)
        {
            if (clsVendedores.vendedoresL.Count > 0)
            {
                listaActulizada();
            }
            txtVendedor.CharacterCasing = CharacterCasing.Upper;
        }

        private void listaActulizada()
        {

            listBox1.DataSource = null;
            listBox1.DataSource = clsVendedores.vendedoresL;


        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (txtVendedor.Text.Length > 0)
            {
                clsVendedores.vendedoresL.Add(txtVendedor.Text);
                clsVendedores.vendedoresL.Sort();

                listaActulizada();

                txtVendedor.Clear();
                txtVendedor.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un vendedor en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVendedor.Focus();
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro de eliminar el vendedor seleccionado?",
                               "ELIMINAR VENDEDOR",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                clsVendedores.vendedoresL.Remove(listBox1.SelectedValue.ToString());
                listaActulizada();
            }
        }

    
    }
}
