using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftMobs_Aplicacion
{
    public partial class frmAgregar : Form
    {
        frmMain formularioMain; //Atributo para una instancia de frmMain
        public frmAgregar(frmMain formulario)
        {
            InitializeComponent();
            formularioMain = formulario; //Asignamos la instancia que entra desde frmMain a nuestro atributo
            //pictureBox1.Image = Image.FromFile("C:\\Users\\sanch\\Downloads\\cerdo.jpg");
        }

        private void rdbPasivo_Click(object sender, EventArgs e) //Funcion para cuando el radio de pasivo este activo
        {
            grbHostil.Visible = false; //Se oculta los datos de los hostiles
            grbPasivo.Visible = true;  //Se hace visible los datos de los pasivos
        }

        private void rdbNeutral_Click(object sender, EventArgs e) //Funcion para cuando el radio de neutral esta activo
        {
            grbHostil.Visible = true;   //Se hace visible los datos de los hostiles
            grbPasivo.Visible = false;  //Se oculta los datos de los pasivos
        }

        private void rdbHostil_Click(object sender, EventArgs e) //Funcion para cuando el radio de hostiles esta activo
        {
            grbHostil.Visible = true;   //Se hace visible los datos de los hostiles
            grbPasivo.Visible = false; //Se oculta los datos de los pasivos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog lectorDeArchivos=new OpenFileDialog();
            lectorDeArchivos.FileName = "Seleccione la imagen";
            lectorDeArchivos.Filter = "Archivo jpg (*.jpg)|*jpg";
            lectorDeArchivos.Title = "Abrir camino a imagen";
            if (lectorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                string camino=lectorDeArchivos.FileName;
                if (camino == "Seleccione la imagen" || camino == "") 
                   return; 
                pictureBox1.Image=Image.FromFile(camino);
            }
            

        }
    }
}
