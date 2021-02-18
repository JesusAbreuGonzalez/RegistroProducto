using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegistrosConDetalle.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public int SuplidorId { get; set; }

        [ForeignKey("ProductoId")]
        public virtual List<OrdenesDetalle> OrdenesDetalle { get; set; }
    }
}
