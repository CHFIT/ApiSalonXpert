using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int TiempoCita { get; set; }
        public int Movil {  get; set; }
        public int IdCorporacion { get; set; }

        public int IdServicio { get; set; }

        /*
        [ForeignKey("IdServicio")]
        public virtual Servicios Servicio { get; set; }
        */

    }
}
