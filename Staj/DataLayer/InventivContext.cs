using Microsoft.EntityFrameworkCore;
using InventivCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Staj.Models;
using System.Linq;

namespace InventivCore
{
     public class InventivContext:DbContext
    { 
        public const string ConnectionString = @"Server=LAPTOP-OGFHI0KB;Database= InventivCore;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> DTOOdemePlanis { get; set; }
        public DbSet<Vade> Vadeler { get; set; }

        /* public void InsertDTOOdemePlani()
         {
             using (var db = new InventivContext())
             {
                 var dTOOdemePlani = new DTOOdemePlani() {Adi, Soyadi,Telefon };
                 db.Add(dTOOdemePlani);

                 db.SaveChanges();
             }
         }
        */

        public void Add(User entity)
        {
            using (InventivContext context = new InventivContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void HesaplananVadeEkle(List<Vade> gelenVadeler)
        {
            using (InventivContext context = new InventivContext())
            {

                foreach (var vade in gelenVadeler)
                {
                    var addedEntity = context.Entry(vade);
                    addedEntity.State = EntityState.Added;
                   
                }

                context.SaveChanges();
            }
        }
        public List<Vade> GetAllVade()
        {
            using (InventivContext context=new InventivContext())
            {
                return context.Set<Vade>().ToList();
            }
        }
       

    }
}
