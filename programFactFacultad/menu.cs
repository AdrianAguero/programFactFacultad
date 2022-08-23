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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void botonVendedores_Click(object sender, EventArgs e)
        {
            listaDeVendedores formularioVendedores = new listaDeVendedores();
            formularioVendedores.Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
