using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteraClientes.WPF.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(13)]
        public string Telefono { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
