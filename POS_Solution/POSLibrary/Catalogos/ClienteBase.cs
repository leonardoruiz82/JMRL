using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSLibrary.Catalogos
{
    public class ClienteBase : PersonaBase
    {
        int ClienteId { get; set; }
        string Codigo { get; set; }        
    }
}
