using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int ServicioId { get; set; }
        public Servicios Servicios { get; set; }



        public Cliente()
        {
            Servicios = new Servicios(1, "Amalgama Clase I",60);
            ServicioId = Servicios.Id;
        }



        public Cliente(int id, string nombre,int telefono, string direccion,Servicios servicios)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Servicios = servicios;
            ServicioId = servicios.Id;

        }

    }
}
