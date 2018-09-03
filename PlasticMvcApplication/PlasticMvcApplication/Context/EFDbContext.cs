using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PlasticMvcApplication.Models;

namespace PlasticMvcApplication.Context
{
    //Связываем нашу модель с базой данных
    public class EFDbContext:DbContext
    {
       
            public DbSet<Product> Products { get; set; }
       
    }
}