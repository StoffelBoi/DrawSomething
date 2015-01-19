using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawSomething
{
    public partial class TestImage : Form
    {
        private GameServer server;
        private GameClient client;
        public TestImage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var port = int.Parse(txtPort.Text);
            var ip = IPAddress.Parse(txtIP.Text);
            if (isServer.Checked)
            {
                server = new GameServer(ip, port);
                server.DataRecieved += (s, ev) => { pictureBox1.Image = server.GetData().Image1; };
            }
            else
            {
                client = new GameClient(ip, port);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(openFileDialog1.FileName);
                var data = new Data(Type.Image, image);
                client.WriteData(data);
            }
        }
    }
}
