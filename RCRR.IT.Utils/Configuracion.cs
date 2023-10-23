using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;



namespace RCRR.IT.Utils
{
    public class Configuracion
    {
        public static string conexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            }
        }


    }
}
