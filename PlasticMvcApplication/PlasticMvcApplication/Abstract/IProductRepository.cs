using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasticMvcApplication.Models;

namespace PlasticMvcApplication.Abstract
{
    
    
    //Интерфейс абстрактного хранилища
  public interface IProductRepository
    {
      IQueryable<Product> Products { get; }
    }
}
