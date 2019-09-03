using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cambio_de_colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lblrojo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            MessageBox.Show("presiona otro color este es muy oscuro jeje");
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
