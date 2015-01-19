using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace DrawSomething
{
    class GameServer
    {
        private TcpListener _tcpListener;
        private TcpClient _client;
        private NetworkStream _stream;
        private byte[] _buffer;
        private IPAddress _ipAddress;
        private int _port;

        public event EventHandler DataRecieved;

        public GameServer(IPAddress ip, int port)
        {
            _ipAddress = ip;
            _port = port;
            _buffer = new byte[4096];
            _tcpListener = new TcpListener(_ipAddress, _port);
            _tcpListener.Start();
            _tcpListener.BeginAcceptTcpClient(DoAcceptTcpClientCallback, _tcpListener);
        }

        private void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            var listener = (TcpListener) ar.AsyncState;
            _client = listener.EndAcceptTcpClient(ar);
            _stream = _client.GetStream();
            _stream.BeginRead(_buffer, 0, _buffer.Length, DoBeginRead, _stream);
        }

        public void WriteData(Data data)
        {
            var byteData = data.GetBytes();
            _stream.BeginWrite(byteData, 0, byteData.Length, DoBeginWrite, null);
        }

        public Data GetData()
        {
            var data = new Data();
            data.GetData(_buffer);
            return data;
        }

        private void DoBeginRead(IAsyncResult ar)
        {
            _stream.EndRead(ar);
            OnRecievedData();
            _stream.BeginRead(_buffer, 0, _buffer.Length, DoBeginRead, _stream);
        }

        private void DoBeginWrite(IAsyncResult ar)
        {
            _stream.EndWrite(ar);
        }

        protected void OnRecievedData()
        {
            var e = DataRecieved;
            if (e != null)
            {
                e.Invoke(this, new EventArgs());
            }
        }
    }
}
