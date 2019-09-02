using SistemaOdontologico.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.BL
{
    public class ClienteBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();

        }

        private void CrearDatosdePrueba()
        
        {
            var servicio1 = new Servicios(1, "Amalgama Clase I",24);
            var servicio2 = new Servicios(2, "Endodoncia",60);

            var cliente1= new Cliente(1, "Juan Lopez", 98651243, "Col Moderna", servicio1);
            var cliente2 = new Cliente(2, "Angela Posas", 97568942, "Col Rubi", servicio2);
            var cliente3 = new Cliente(3, "Karla Mendoza", 33695872, "Col Palermo", servicio1);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        

    }
    }
}
