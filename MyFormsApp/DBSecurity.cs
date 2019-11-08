using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsApp
{
    class DBSecurity
    {
        string connectionString = @"Data Source=localhost;Initial Catalog = Student; Integrated Security = True";

        public string ConnectionString { get => connectionString; }
    }
}
