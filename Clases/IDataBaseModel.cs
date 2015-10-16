using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDeDatos.Clases
{
    interface IDataBaseModel
    {


        public String nameServer { get; private set; }
        public String user { get; private set; }
        public String password { get; private set; }
        public int port { get; private set; }
        public Boolean encript { get; private set; }
        
        Boolean Open() { return true; }

        Boolean Execute() { return true; }

        Boolean Close() { return true; }
    }
}
