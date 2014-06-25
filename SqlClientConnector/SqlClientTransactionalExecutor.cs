using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CoreComponents.Data;

namespace SqlClientConnector
{

    public class SqlClientTransactionalExecutor : TransactionalExecutor<SqlConnection, SqlCommand, SqlParameter>
    {

        public SqlClientTransactionalExecutor()
        {
        }

    }

}
