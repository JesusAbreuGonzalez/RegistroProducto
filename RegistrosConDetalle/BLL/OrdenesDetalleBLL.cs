using RegistrosConDetalle.DAL;
using RegistrosConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrosConDetalle.BLL
{
    public class OrdenesDetalleBLL
    {
        public static bool Guardar(OrdenesDetalle ordenesDetalle)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.OrdenesDetalle.Add(ordenesDetalle) != null)
                    paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        
    }
}
