using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int ID_COMPRA { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List <Detalle_Compra> oDetalleCompra { get; set; }//Tipo lista porque una compra puede involucrar varios productos y estos productos estan en la tabla detalle de compra
        public string FechaRegistro { get; set; }
    }
}
