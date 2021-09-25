using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendUsuarios.Datos.Entitys
{
    public class Usuario  
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public String Name { get; set; }
         
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public String ParqueAsociado { get; set; }
    }
}
