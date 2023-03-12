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
    public partial class PantallaInformacion : Form
    {
        public PantallaInformacion()
        {
            InitializeComponent();
            libros.Titles.Add("libros");

            libros.Series["libros"].IsValueShownAsLabel = true;
            libros.Series["libros"].Points.AddXY("HARRY POTTER", "25");
            libros.Series["libros"].Points.AddXY("GOOSEBUMP", "30");
            libros.Series["libros"].Points.AddXY("PERRY MASON", "26");

            programas.Titles.Add("programas de entrenimiento");

            programas.Series["programas"].IsValueShownAsLabel = true;
            programas.Series["programas"].Points.AddXY("Programas de entrenimiento", "25");
            programas.Series["programas"].Points.AddXY("libros", "25");
            programas.Series["programas"].Points.AddXY("Lenguajes de programacion", "50");

            lenguajes.Titles.Add("Lenguajes de programacion");

            lenguajes.Series["lenguajes"].IsValueShownAsLabel = true;
            lenguajes.Series["lenguajes"].Points.AddXY("PYTON", "47");
            lenguajes.Series["lenguajes"].Points.AddXY("JAVA", "38");
            lenguajes.Series["lenguajes"].Points.AddXY("JAVASCRIPT", "15");
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;


        }

        private void theMarvelousMrsMaiselToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rb1.Visible = true;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = true;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }

        private void harryPotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = true;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img3.Visible = false;
            img4.Visible = true;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }

        private void goodsebumpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = true;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = true;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;


        }

        private void perryMasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = true;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = true;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = true;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = true;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = true;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = true;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = true;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = true;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }

        private void pantallaGraficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = false;
            libros.Visible = true;
            programas.Visible = true;
            lenguajes.Visible = true;
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = true;
            infografica.Visible = true;
            imgfondo.Visible = false;


        }

        private void gamesOfTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = true;
            rb9.Visible = false;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = true;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;
        }

        private void chernobylToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
            rb9.Visible = true;
            libros.Visible = false;
            programas.Visible = false;
            lenguajes.Visible = false;
            img1.Visible = false;
            img2.Visible=true;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;
            img7.Visible = false;
            img8.Visible = false;
            img9.Visible = false;
            infografica.Visible = false;
            infografica.Visible = false;
            imgfondo.Visible = false;

        }


    }


    }
 

