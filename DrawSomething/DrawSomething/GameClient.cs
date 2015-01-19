using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace DrawSomething
{
    class GameClient
    {
        private IPAddress _ipAddress;
        private int _port;
        private TcpClient _client;
        private byte[] _buffer;
        private NetworkStream _stream;

        public GameClient(IPAddress ip, int port)
        {
            _ipAddress = ip;
            _port = port;
            _client = new TcpClient();
            _buffer = new byte[4096*16];
            _client.BeginConnect(_ipAddress, _port, DoBeginConnect, _client);
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

        private void DoBeginConnect(IAsyncResult ar)
        {
            var client = (TcpClient)ar.AsyncState;
            client.EndConnect(ar);
            _stream = client.GetStream();
            _client = client;
            _stream.BeginRead(_buffer, 0, _buffer.Length, DoBeginRead, _stream);
        }

        private void DoBeginRead(IAsyncResult ar)
        {
            _stream.EndRead(ar);
            _stream.BeginRead(_buffer, 0, _buffer.Length, DoBeginRead, _stream);
        }

        private void DoBeginWrite(IAsyncResult ar)
        {
            _stream.EndWrite(ar);
        }
    }
}
