using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlasticMvcApplication.Abstract;
using PlasticMvcApplication.Context;
using PlasticMvcApplication.Models;

namespace PlasticMvcApplication.Conserate
{
    //Создаем хранилище Product
    public class EFProductRepository:IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Product> Products
        {
            get { return context.Products; }
        } 
    }
}