using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClinicaMedicaCodeFirst.DataBase
{
    public class MyDbInitializer : CreateDatabaseIfNotExists<ClinicaMedicaDataLayer>
    {
        protected override void Seed(ClinicaMedicaDataLayer context)
        {
            context.Estados.Add(new Estado { EstadoID = 1, Nombre = "Activo", FechaCrecion = DateTime.Now });
            context.Estados.Add(new Estado { EstadoID = 2, Nombre = "Inactivo", FechaCrecion = DateTime.Now });
            base.Seed(context);
        }
    }
}