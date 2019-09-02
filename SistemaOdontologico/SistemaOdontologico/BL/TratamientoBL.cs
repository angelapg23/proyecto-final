using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaOdontologico.Modelos;


namespace SistemaOdontologico.BL
{
    public class TratamientoBL
    {
        public BindingList<Tratamiento> ListadeTratamientos { get; set; }


        public TratamientoBL()
        {
            ListadeTratamientos = new BindingList<Tratamiento>();
            DatosdePrueba();


        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var tratamiento in ListadeTratamientos )
            {
                if (tratamiento.Id == id )
                {
                    precio = tratamiento.Precio;
                }
            }

            return precio;
        }

        private void DatosdePrueba()
        {
            var tratamiento1 = new Tratamiento(1, "Amalgama Clase I", 60);
            var tratamiento2 = new Tratamiento(2, "Amalgama Clase II", 70);
            var tratamiento3 = new Tratamiento(3, "Cirugia por Unidad", 150);
            var tratamiento4 = new Tratamiento(4, "Radiografias", 24);
            var tratamiento5 = new Tratamiento(5, "Exodoncia por unidad", 24);
            var tratamiento6 = new Tratamiento(6, "Endodoncia", 90);
            var tratamiento7 = new Tratamiento(7, "Profilaxis", 60);
            var tratamiento8 = new Tratamiento(8, "Resina Clase I", 85);
            var tratamiento9 = new Tratamiento(9, "Resina Clase II", 120);
            var tratamiento10 = new Tratamiento(10, "Resina Clase III", 120);

            ListadeTratamientos.Add(tratamiento1);
            ListadeTratamientos.Add(tratamiento2);
            ListadeTratamientos.Add(tratamiento3);
            ListadeTratamientos.Add(tratamiento4);
            ListadeTratamientos.Add(tratamiento5);
            ListadeTratamientos.Add(tratamiento6);
            ListadeTratamientos.Add(tratamiento7);
            ListadeTratamientos.Add(tratamiento8);
            ListadeTratamientos.Add(tratamiento9);
            ListadeTratamientos.Add(tratamiento10);
        }
    }
}
