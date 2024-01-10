using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Medio_de_pago
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString() //para que cuando yo llamme al objeto no se imprima la definición del objeto(porque en la grilla eso es lo que pasa que se llama al metodo heredado por la clase object padre y lo imprime) debo overridearlo
        {
            return Descripcion;
        }
    }
}
