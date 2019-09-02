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
    public partial class Menu : Form

    {
        ClienteBL _clientesBL;
        ServiciosBL _serviciosBL;
        TratamientoBL _tratamientosBL;
        FacturaBL _facturasBL;

        public Menu()
        {
            InitializeComponent();
            _clientesBL = new ClienteBL();
            _serviciosBL = new ServiciosBL();
            _tratamientosBL = new TratamientoBL();
            _facturasBL = new FacturaBL();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new Clientes();
            formclientes.MdiParent = this;
            formclientes.CargarDatos(_clientesBL, _serviciosBL);
            formclientes.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtratamiento = new Tratamientos ();
            formtratamiento.MdiParent = this;
            formtratamiento.CargarDatos(_tratamientosBL);
            formtratamiento.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
           
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form1();
            formFactura.MdiParent = this;

            formFactura.CargarDatos(_facturasBL, _clientesBL, _tratamientosBL);

            formFactura.Show();

        }
    }
}
