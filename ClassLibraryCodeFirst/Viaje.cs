using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbViaje")]
    public class Viaje
    {
        [Key]
        [Column("idViaje", TypeName = "int")]
        public int IdViaje { get; set; }

        [Required]
        [Column("idTarjeta", TypeName = "int")]
        public int IdTarjeta { get; set; }
        [Required]
        [Column("idPais", TypeName = "int")]
        public int IdPais { get; set; }
        [Column("fechaInicioViaje", TypeName = "datetime")]
        public DateTime FechaInicioViaje { get; set; }
        [Column("fechaFinViaje", TypeName = "datetime")]
        public DateTime FechaFinViaje { get; set; }
        [Column("estadoViaje", TypeName = "nvarchar")]
        public string EstadoViaje { get; set; }
        public Tarjeta Tarjeta { get; set; }
        public Pais Pais { get; set; }
    }
}
