﻿using System;
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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuarios formRegistro = new RegistroUsuarios();
            formRegistro.ShowDialog();
           
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            TextReader Inicio = new StreamReader(txNombre.Text + ".txt");
            if (Inicio.ReadLine() != txContraseña.Text)
            {
                MessageBox.Show("no se pudo iniciar sesion");
               
            }
            else
            {
                txNombre.Clear();
                txContraseña.Clear(); 
                this.Hide();
                PantallaInformacion informacion = new PantallaInformacion();
                informacion.ShowDialog();
            }
        }
    }
}
 