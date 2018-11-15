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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarCancionBtn_Click(object sender, EventArgs e)
        {
            Agregar_Cancion vista = new Agregar_Cancion();
            vista.Show();
        }

        private void eliminarCancionBtn_Click(object sender, EventArgs e)
        {
            Listar_Eliminar vista = new Listar_Eliminar();
            vista.Show();
        }

        private void listadoCancionesBtn_Click(object sender, EventArgs e)
        {
            Listar_Eliminar vista = new Listar_Eliminar();
            vista.Show();
        }
    }
}
