using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace prueba_jaramillo_villegas.DTO
{
    public class StateObjectDTO
    {
        public Socket workSocket = null;

        public const int BufferSize = 256;

        public byte[] buffer = new byte[BufferSize];

        public StringBuilder stringBuilder = new StringBuilder();
    }
}
