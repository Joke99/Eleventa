using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductoDAL
    {
        private static EleventaEntities db = new EleventaEntities();

        #region Crear
        //CREATE
        public static bool createProducto(Producto producto)
        {

            try
            {
                
                    db.Productoes.Add(producto);
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


        #region Modificar
        //UPDATE

        public static bool updateProducto(Producto producto)
        {
            try
            {
                
                    db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                    int changes = db.SaveChanges();

                    if (changes > 0)
                        return true;
                    else
                        return false;
                
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

        #region Eliminar
        //DELETE

        public static bool deleteProducto(string id)
        {
            try
            {
                
                    // Realizamos la consulta
                    var query = db.Productoes.Where(p => p.CodigoBarra ==
                       id).First();

                    // Eliminamos el cliente
                    db.Productoes.Remove(query);    // Para el Framework 4.0 o inferior

                    // Guardamos los cambios
                    int res = db.SaveChanges();

                    return res > 0;
                
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

        #region Buscar
        //READ BY ID

        public static Producto getProductoByDescription(string id)
        {
           
                var query = (from p in db.Productoes
                             where p.CodigoBarra == id
                             select p).Single();

                return query;
            

        }
        #endregion
    }
}
