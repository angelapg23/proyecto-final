using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Modelos
{
    public class Servicios
    {
        public int Id { get; set; }
        public string Tratamiento { get; set; }
        public double Precio { get; set; }

        public Servicios()
        {

        }

        public Servicios(int id, string tratamiento,double precio)
        {
            Id = id;
            Tratamiento = tratamiento;
            Precio = precio;
          

        }
    }
}
