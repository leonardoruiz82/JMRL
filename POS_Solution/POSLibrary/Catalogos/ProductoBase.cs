using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSLibrary.Catalogos
{
    public class ProductoBase
    {
        Int32 ProductoId { get; set; }
        string Codigo { get; set; }
        string Descripcion { get; set; }
        decimal Precio { get; set; }
        decimal Costo { get; set; }
        bool TieneImpuesto{ get; set; }
    }


}
