using SistemaOdontologico.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdontologico
{
    public partial class Tratamientos : Form
    {
        public Tratamientos()
        {
            InitializeComponent();
        }

        public void CargarDatos(TratamientoBL tratamientosBL)
        { 
            
            listadeTratamientosBindingSource.DataSource = tratamientosBL.ListadeTratamientos;
     
}

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void precioLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
