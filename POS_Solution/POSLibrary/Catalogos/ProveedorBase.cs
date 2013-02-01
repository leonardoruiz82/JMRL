using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSLibrary.Catalogos
{
    public class ProveedorBase : PersonaBase
    {
        int ProveedorId { get; set; }
        string Codigo { get; set; }
    }
}
