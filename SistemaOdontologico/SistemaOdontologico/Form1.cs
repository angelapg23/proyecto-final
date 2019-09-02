using SistemaOdontologico.BL;
using SistemaOdontologico.Modelos;
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
    public partial class Form1 : Form
    {
        FacturaBL _facturaBL;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void CargarDatos(FacturaBL facturasBL, ClienteBL clientesBL, TratamientoBL tratamientosBL)
        {
            _facturaBL = facturasBL;

            listadeFacturasBindingSource.DataSource = facturasBL.ListadeFacturas;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeTratamientosBindingSource.DataSource = tratamientosBL.ListadeTratamientos;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularTotalFactura();

            listadeFacturasBindingSource.ResetBindings(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
