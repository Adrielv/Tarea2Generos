using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea2Generos.DAL;
using Tarea2Generos.Entidades;

namespace Tarea2Generos.BLL
{
    public class GenerosBLL
    {
        public static bool Guardar(Generos generos)
        {
            bool paso = false;

            Contexto db = new Contexto();

            try
            {

                db.Generos.Add(generos);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static bool Modificar(Generos generos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(generos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            { 
                throw;
            }
            finally 
            { 
                db.Dispose();
            }


            return paso;
        }


        public static bool Eliminar(int Id)
        {
            bool paso = false;

            Contexto db = new Contexto();

            try
            {

                Generos generos = db.Generos.Find(Id);

                if (generos != null)
                {
                    db.Entry(generos).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;

                }


            }
            catch (Exception) { throw; }
            finally { db.Dispose(); }



            return paso;
        }


        public static Generos Buscar(int Id)
        {
            Generos generos = null;
            Contexto db = new Contexto();

            try
            {
                generos = db.Generos.Find(Id);



            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }



            return generos;
        }



        public static List<Generos> GetList()
        {
            List<Generos> lista = new List<Generos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Generos.Where(G => true).ToList();

            }
            catch (Exception) 
            {
                throw;
            }
            finally 
            {
                db.Dispose(); 
            }


            return lista;

        }


    }
}

