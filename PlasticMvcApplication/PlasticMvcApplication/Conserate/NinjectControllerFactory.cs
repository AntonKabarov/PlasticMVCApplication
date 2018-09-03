using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Ninject;
using PlasticMvcApplication.Abstract;
using PlasticMvcApplication.Models;
namespace PlasticMvcApplication.Conserate
{
    //Добавляем имитированную реализацию IProductRepository
    public class NinjectControllerFactory:DefaultControllerFactory
    {
         private IKernel ninjectKernel;
         public NinjectControllerFactory()
         {
             ninjectKernel = new StandardKernel();
             AddBindings();
         }
    protected override IController GetControllerInstance(RequestContext reqCont, Type contType)

         {
             return contType == null
               ? null
               : (IController)ninjectKernel.Get(contType);
         }
       
         // заменим привязку Ninject к нашему имитированному хранилищу на привязку к 
          //реальному хранилищу
            private void AddBindings() 
    { 
      ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>(); 
    } 
         
    }
}