using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public bool Pagado { get; set; }
        public string Imagen { get; set; }
        public Medio_de_pago FormaDePago { get; set; }

    }
}
