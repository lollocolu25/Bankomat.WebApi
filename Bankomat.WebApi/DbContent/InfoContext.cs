using Bankomat.WebApi.Controller;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.DbContent
{
    public class InfoContext : DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        {
              
        }
        //public DbSet<Utenti> Utenti { get; set; } = null!;
        //public DbSet<BancheFunzionalità> BancheFunzionalità { get; set; } = null!;
        //public DbSet<Funzionalità> Funzionalità { get; set; } = null!;

        //public InfoContext(DbContextOptions<InfoContext> options) : base(options)
        //{


        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Utenti>().HasData(
        //        new Utenti("Mare")
        //        {
        //            Id = 1,
        //            Name = "Mare.",
        //            Prezzo = 5,
        //            Sku = "ghgh",

        //        },
        //        new Utenti("Montagna")
        //        {
        //            Id = 2,
        //            Name = "Montagna.",
        //            Prezzo = 6,
        //            Sku = "ghghg",
        //        },
        //        new Utenti("Classica")
        //        {
        //            Id = 3,
        //            Name = "Classica.",
        //            Prezzo = 4,
        //            Sku = "ghghgh",
        //        }); ;

        //    modelBuilder.Entity<BancheFunzionalità>().HasData(
        //        new BancheFunzionalità("coca cola")
        //        {
        //            Id = 1,
        //            Name = "coca cola.",
        //            Prezzo = 3,
        //            Sku = "fhfh",

        //        },
        //        new BancheFunzionalità("fanta")
        //        {
        //            Id = 2,
        //            Name = "fanta.",
        //            Prezzo = 3,
        //            Sku = "fhfhf",
        //        },
        //        new BancheFunzionalità("acqua")
        //        {
        //            Id = 3,
        //            Name = "acqua.",
        //            Prezzo = 4,
        //            Sku = "fhfhfh",
        //        }); ;
        //    modelBuilder.Entity<Funzionalità>().HasData(
        //        new Funzionalità("kit kat")
        //        {
        //            Id = 1,
        //            Name = "kit kat.",
        //            Prezzo = 3,
        //            Sku = "thth",

        //        },
        //        new Funzionalità("twix")
        //        {
        //            Id = 2,
        //            Name = "twix.",
        //            Prezzo = 3,
        //            Sku = "ththt",
        //        },
        //        new Funzionalità("kinder")
        //        {
        //            Id = 3,
        //            Name = "kinder.",
        //            Prezzo = 4,
        //            Sku = "ththth",
        //        }); ;
        //}
    }
}
