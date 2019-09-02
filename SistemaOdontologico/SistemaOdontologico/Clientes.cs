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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        

}
            public void CargarDatos(ClienteBL clientesBL, ServiciosBL serviciosBL)
        {
            
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;


            listadeServiciosBindingSource.DataSource = serviciosBL.ListadeServicios;
        }

        
    }
}
