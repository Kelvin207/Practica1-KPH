using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbPais")]
    public class Pais
    {
        [Key]
        [Column("idPais", TypeName = "int")]
        public int IdPais { get; set; }
        [StringLength(50)]
        [Column("nombrePais", TypeName = "nvarchar")]        
        public string NombrePais { get; set; }
        [StringLength(10)]
        [Column("codigoPais", TypeName = "nvarchar")]
        public string CodigoPais { get; set; }
        public List<Viaje> Viajes { get; set; }
    }
}
