using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLogin { get; set; }
        public int IdCorporacion { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public int Email { get; set; }

    }
}
