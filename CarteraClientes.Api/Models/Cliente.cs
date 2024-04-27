namespace CarteraClientes.Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            
        }

        public int Id { get; set; }

        [StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(13)]
        public string Telefono { get; set; }

        public DateTime? FechaCreacion { get; set; }

    }
}
