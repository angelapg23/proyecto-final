using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Modelos
{
    public class Tratamiento

    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }


        public Tratamiento()
        {
            var tratamiento1 = new Tratamiento(1, "Amalgama Clase I", 60);

        }

        public Tratamiento(int id, string descripcion, double precio)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;

        }
    }
    
}
