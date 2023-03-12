using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Desafio_1
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
           
        }
        //vuelve a la pantalla de inicio (login)
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion formlogin = new InicioSesion();
            formlogin.ShowDialog();
        }
        //guarda la contra, preferencia de informacion y el usuario en la siguiente direcciones locales (simulacionde base de datos)
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\Ignacio\Desktop\new\Desafio 1 (2)1\bin\Debug\" + txNombre.Text + ".txt", true);
            RegistrarUsuario.WriteLine(txContraseña.Text);
            RegistrarUsuario.Close();
            TextWriter RegistrarItem = new StreamWriter(@"C:\Users\Ignacio\Desktop\new\Desafio 1 (2)1\bin\Debug\" + txNombre.Text + ".txt", true);
            RegistrarItem.WriteLine(txItem.Text);
            RegistrarItem.Close();
            txNombre.Clear();
            txContraseña.Clear();
        }
        

    }
}
