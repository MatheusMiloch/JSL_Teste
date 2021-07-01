using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSL.Models
{

    public class Context : DbContext
    {
        public DbSet<Motorista> Motoristas { get; set; }   
        public DbSet<Viagem> Viagens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-J1DNMFR\SQLEXPRESS01 ; Integrated Security =SSPI ; Initial Catalog = JSL;");
        }
    }
}
