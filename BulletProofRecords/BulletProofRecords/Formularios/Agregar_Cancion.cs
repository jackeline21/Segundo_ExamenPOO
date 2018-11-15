using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletProofRecords
{
    public partial class Agregar_Cancion : Form
    {
        public Agregar_Cancion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombreTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            CrearCancion.nombre  = nombreTxt.Text;
            CrearCancion.artista = artistaTxt.Text;
            CrearCancion.album = albumTxt.Text;
            CrearCancion.genero = generoTxt.Text;
            CrearCancion.añoCreacion = anioCreacionTxt.Text;

        }
    }
}
