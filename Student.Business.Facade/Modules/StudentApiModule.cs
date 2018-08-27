using Autofac;
using Autofac.Integration.WebApi;
using Student.Business.Logi.BusinessLogic;
using Student.Business.Logi.Modules;
using Student.Business.Logic.Contracts;
using Student.Common.Logic.Log4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Student.Business.Facade.Modules
{
    public class StudentApiModule: Autofac.Module
    {
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder
                .RegisterType<StudentBL>()
                .As<IBusiness>()
                .InstancePerRequest();

            builder
                .RegisterType<Log4netAdapter>()
                .As<ILogger>()
                .InstancePerRequest();

            builder.RegisterGeneric(typeof(FacturaBL<>))  //método register generic, en lugar de decirle la clase typeof
                .As(typeof(IBusinessGeneric<>))
                .AsSelf()
                .InstancePerRequest();   // AsSelf para que se instancie como la interfaz.

            // Cada module, se encarga de inyectar las clases de su capa
            builder.RegisterModule(new BusinessLogicModule());

            base.Load(builder);
        }
    }
}