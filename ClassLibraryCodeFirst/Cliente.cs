using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        [Column("idCliente", TypeName = "int")]
        public int IdCliente { get; set; }
        
        [StringLength(50)]
        [Column("nombreCliente", TypeName = "nvarchar")]
        public string NombreCliente { get; set; }
        [StringLength(50)]
        [Column("apellidosCliente", TypeName = "nvarchar")]
        public string ApellidosCliente { get; set; }
        [Required]
        [Column("fechaNacimiento", TypeName = "datetime")]
        public DateTime FechaNacimiento { get; set; }
        [StringLength(15)]
        [Column("dniCliente", TypeName = "nvarchar")]
        public string DniCliente { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }
    }
}
