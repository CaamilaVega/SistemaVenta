using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol
    {
        public int ID_ROL { get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; } //se coloca automatico en la base de datos no se completa por aca
    }
}
