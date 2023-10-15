using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Facturacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }

        public int Pago { get; set; }

        public DateTime Fecha { get; set; }

        public int IdServicio { get; set; }


        /*[ForeignKey ("IdServicio")]
        public virtual Servicios Servicio { get; set; }*/
    }
}
