using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDeDatos.Clases
{
    class DataBaseConnect:IDataBaseModel
    {
        public string nameServer
        {
            get;
            private set;
        }

        public string user
        {
            get;
            private set;
        }

        public string password
        {
            get;
            private set;
        }

        public int port
        {
            get;
            private set;
        }

        public bool encript
        {
            get;
            private set;
        }

        public bool Open()
        {
            throw new NotImplementedException();
        }

        public bool Open(String _nameDataBase)
        {
            throw new NotImplementedException();
        }

        public bool Execute(String sentence)
        {
            throw new NotImplementedException();
        }

        public bool Close()
        {
            throw new NotImplementedException();
        }
    }
}
