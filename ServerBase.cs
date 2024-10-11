using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTServerLib
{
    abstract class ServerBase(ushort port)
    {
        public ushort Port { get; } = port;

        public bool SendPacket()
        {
            return true;
        }

        public bool Disconnect()
        {
            return true;
        }

        protected abstract void OnRecv();
        protected abstract void OnAccept();
        protected abstract void OnDisconnect();

    }
}
