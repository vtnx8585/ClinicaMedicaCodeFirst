﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ClinicaMedicaCodeFirst.Interfaces
{
    public interface IDataBaseConn
    {
        SqlConnection ConnectionOpen(String connection);
        void ConnectionClose(String connection);
    }
}