using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CDatos_Login;
using System.Data;

namespace CNegocios_Login
{
    public class Class1
    {
        CDatos_Login.Class1 objd = new CDatos_Login.Class1();

        public DataTable N_Login(CEntidades_Login.Class1 obje)
        {
            return objd.D_Login(obje);
        }

    }
}