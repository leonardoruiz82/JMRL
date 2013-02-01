using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSLibrary.Catalogos
{
    public class PersonaBase
    {
        enum eTipoPersona
        {
            Moral = 1,
            Fisica = 2
        }
        string Nombre { get; set; }
        string ApellidoPaterno { get; set; }
        string ApellidoMaterno { get; set; }
        string Correo { get; set; }
        string Telefono { get; set; }
        string RazonSocial { get; set; }
        eTipoPersona TipoPersona { get; set; }

        private void LlenarNombreCompleto()
        {
 
        }
    }


}
