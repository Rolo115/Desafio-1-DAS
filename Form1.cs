using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_1
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Barracarga.Increment(10);
            Porcentaje.Text = Barracarga.Value.ToString() + "%";
            if (Barracarga.Value == Barracarga.Maximum)
            {
                tiempo.Stop();
                this.Hide();
                InicioSesion formlogin = new InicioSesion();
                formlogin.ShowDialog();
            }
        }
        private void Porcentaje_Click(object sender, EventArgs e)
        {

        }



    }
}
