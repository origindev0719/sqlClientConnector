using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CoreComponents.Data;

namespace SqlClientConnector
{

    public class SqlClientQuickDiscreteExecutor : QuickDiscreteExecutor<SqlConnection, SqlCommand, SqlParameter>
    {

        public SqlClientQuickDiscreteExecutor()
        {
        }

    }

}
