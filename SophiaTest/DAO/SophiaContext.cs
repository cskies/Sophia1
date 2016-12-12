using SophiaTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SophiaTest.DAO
{
    public class SophiaContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }
    }
}