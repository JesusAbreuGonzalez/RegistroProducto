using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistrosConDetalle.Entidades
{
    public class OrdenesDetalle
    {
        [Key]
        public int OrdenDetalleId { get; set; }
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }

        public OrdenesDetalle()
        {
            OrdenDetalleId = 0;
            OrdenId = 0;
            ProductoId = 0;
            Cantidad = 0;
        }

        public OrdenesDetalle(int ordenId, int productoId, int cantidad)
        {
            OrdenDetalleId = 0;
            OrdenId = ordenId;
            ProductoId = productoId;
            Cantidad = cantidad;
        }
    }
}
