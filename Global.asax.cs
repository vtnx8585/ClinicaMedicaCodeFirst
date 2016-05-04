using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Data.Entity;
using ClinicaMedicaCodeFirst;
using ClinicaMedicaCodeFirst.DataBase;

namespace ClinicaMedicaCodeFirst
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciarse la aplicación
            AuthConfig.RegisterOpenAuth();
            ClinicaMedicaDataLayer context = new ClinicaMedicaDataLayer();
            context.Database.Initialize(true);

            //String DataBaseType = "Sql";
            //Session["DataBaseType"] = DataBaseType;

            //Database.SetInitializer(new CreateDatabaseIfNotExists<ClinicaMedicaDataLayer>());
            //Database.SetInitializer<ClinicaMedicaDataLayer>(new CreateDatabaseIfNotExists<ClinicaMedicaDataLayer>());
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta al cerrarse la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se produce un error sin procesar

        }
    }
}
