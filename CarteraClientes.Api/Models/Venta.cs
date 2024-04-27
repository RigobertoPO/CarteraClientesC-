namespace CarteraClientes.Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venta
    {
        public Guid Id { get; set; }

        public int? IdCliente { get; set; }

        public DateTime? FechaVenta { get; set; }

        public decimal Total { get; set; }

       
    }
}
