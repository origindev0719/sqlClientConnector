using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CoreComponents.Data;

namespace SqlClientConnector
{

    public class SqlClientConnectionAndCommandManager : ConnectionAndCommandManager<SqlConnection, SqlCommand, SqlParameter>
    {

        public SqlClientConnectionAndCommandManager()
        {
        }

    }

}
