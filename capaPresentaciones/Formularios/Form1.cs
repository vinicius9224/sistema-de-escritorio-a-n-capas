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
        //metodo para limpiar los textbox (recorre todo los controles , cuando encuentra el control textbox , lo limpia)
        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        private bool Validar() // metodo para verificar si hay un textbox vacio(recorre todo los controles ,con el IsNullOrWhiteSpace nos damos cuenta si es nula o esta vacia , si esto pasa retornamos un false)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {
                //llamamos al metodo validar y si este es igual a false , significa que esta vacia o nula.
                if (Validar()==false)
                {
                 MessageBox.Show("No pueden quedar espacios en blanco.");
                }
               else
               {
                 objeto.AgregarAlumno(txtcod.Text, txtnom1.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txtfech.Text, txtresp.Text, txtcol.Text, txtgra.Text, txtdom.Text, txteva.Text, txtfk1.Text, txtfk2.Text);
                 MessageBox.Show("Alumno Agregado");
                 limpiar_Datos();
               }
            }
            catch (Exception ex)
            {
            MessageBox.Show("no se puedo agregar por" + ex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
