using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VentaDAL
    {
        private static EleventaEntities db = new EleventaEntities();

        #region Crear
        //CREATE
        public static bool createVenta(Venta v)
        {

            try
            {

                db.Ventas.Add(v);
                db.SaveChanges();

                return true;

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                            error.PropertyName, error.ErrorMessage);
                    }

                }
            }
            return false;

        }
        #endregion



    }
}
