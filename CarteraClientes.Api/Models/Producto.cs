namespace CarteraClientes.Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Productos")]
    public partial class Producto
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public decimal? Precio { get; set; }
    }
}
