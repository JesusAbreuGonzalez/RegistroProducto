using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegistrosConDetalle.Entidades
{
    public class Ordenes
    {
        [Key]
        public int OrdenId { get; set; }
        public DateTime OrdenFecha { get; set; }
        public int SedeId { get; set; }

        public Ordenes()
        {
            OrdenId = 0;
            OrdenFecha = DateTime.Now;

            OrdenesDetalle = new List<OrdenesDetalle>();
        }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalle> OrdenesDetalle { get; set; }
    }
}
