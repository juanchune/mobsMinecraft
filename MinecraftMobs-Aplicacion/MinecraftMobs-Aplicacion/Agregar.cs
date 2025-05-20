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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void rdbPasivo_Click(object sender, EventArgs e)
        {
            grbHostil.Visible = false;
            grbPasivo.Visible = true;
        }

        private void rdbNeutral_Click(object sender, EventArgs e)
        {
            grbHostil.Visible = true;
            grbPasivo.Visible = false;
        }

        private void rdbHostil_Click(object sender, EventArgs e)
        {
            grbHostil.Visible = true;
            grbPasivo.Visible = false;
        }
    }
}
