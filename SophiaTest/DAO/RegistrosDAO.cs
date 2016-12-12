using SophiaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SophiaTest.DAO
{
    public class RegistrosDAO
    {
        public void Adiciona(Registro registro)
        {
            using (var context = new SophiaContext())
            {
                context.Registros.Add(registro);
                context.SaveChanges();
            }
        }

        public IList<Registro> Lista()
        {
            using (var contexto = new SophiaContext())
            {
                return contexto.Registros.Include("Instituicao").ToList();
            }
        }

        public void Atualiza(Registro registro)
        {
            using (var contexto = new SophiaContext())
            {
                contexto.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}