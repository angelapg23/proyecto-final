using SistemaOdontologico.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.BL
{
    public class ServiciosBL
    {
        public BindingList<Servicios> ListadeServicios { get; set; }

        public ServiciosBL()
        {
            ListadeServicios = new BindingList<Servicios>();
            DatosdePrueba();

        }

        private void DatosdePrueba()
        {
            var servicio1 = new Servicios(1, "Amalgama Clase I", 60); 
            var servicio2 = new Servicios(2, "Endodoncia",70);
            var servicio3 = new Servicios(3, "Amalgama Clase II",24);
            var servicio4 = new Servicios(4, "Cirugia por Unidad",24);
            var servicio5 = new Servicios(5, "Radiografias",24);
            var servicio6 = new Servicios(6, "Exodoncia por unidad",24);
            


            ListadeServicios.Add(servicio1);
            ListadeServicios.Add(servicio2);
            ListadeServicios.Add(servicio3);
            ListadeServicios.Add(servicio4);
            ListadeServicios.Add(servicio5);
            ListadeServicios.Add(servicio6);
        }

    }
}
