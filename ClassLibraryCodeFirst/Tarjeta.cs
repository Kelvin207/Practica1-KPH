using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbTarjeta")]
    public class Tarjeta
    {
        [Key]
        [Column("idTarjeta", TypeName = "int")]
        public int IdTarjeta { get; set; }
        [StringLength(30)]
        [Column("numeroTarjeta", TypeName = "nvarchar")]
        public string NumeroTarjeta { get; set; }
        [StringLength(20)]
        [Column("tipoTarjeta", TypeName = "nvarchar")]
        public string TipoTarjeta { get; set; }
        [StringLength(20)]
        [Column("modoPago", TypeName = "nvarchar")]
        public string ModoPago { get; set; }
        [StringLength(10)]
        [Column("fechaVencimiento", TypeName = "nvarchar")]
        public string FechaVencimiento { get; set; }
        [Required]
        [Column("idCliente", TypeName = "int")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<Viaje> Viajes { get; set; }
    }
}
