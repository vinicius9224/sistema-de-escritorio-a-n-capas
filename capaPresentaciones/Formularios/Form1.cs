using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace capaPresentaciones
{
    public partial class Form1 : Form
    {

        DatosAlumnos objeto = new DatosAlumnos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Mostrar_Alumnos();

        }

        private void Mostrar_Alumnos()
        {

  
         dataGridView1.DataSource = objeto.Mostrar_completo();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
