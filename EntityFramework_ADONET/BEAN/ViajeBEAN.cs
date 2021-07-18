using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET.BEAN
{
    public class ViajeBEAN
    {
        public int IdViaje { get; set; }
        public int IdTarjeta { get; set; }
        public int IdPais { get; set; }
        public DateTime FechaInicioViaje { get; set; }
        public DateTime FechaFinViaje { get; set; }
        public string EstadoViaje { get; set; }
    }
}
