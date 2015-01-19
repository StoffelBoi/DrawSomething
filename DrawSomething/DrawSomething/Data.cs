using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace DrawSomething
{
    public enum Type
    {
        Login,
        Logout,
        Image,
        Text,
        Answer
    }

    public class Data
    {
        public Type MessageType { get; private set; }
        public string Text { get; private set; }
        public Image Image1 { get; private set; }

        #region Constructors
        public Data() { }

        public Data(Type type)
        {
            MessageType = type;
        }

        public Data(Type type, string text) : this(type)
        {
            Text = text;
        }

        public Data(Type type, Image image) : this(type)
        {
            Image1 = image;
        }
        #endregion

        public byte[] GetBytes()
        {
            var msg = new List<byte>();
            msg.AddRange(BitConverter.GetBytes((int)MessageType));
            if (MessageType.Equals(Type.Image))
            {
                using (var ms = new MemoryStream())
                {
                    Image1.Save(ms, ImageFormat.Gif);
                    msg.AddRange(BitConverter.GetBytes(ms.Length));
                    msg.AddRange(ms.ToArray());
                }
            }
            else
            {
                msg.AddRange(BitConverter.GetBytes(Text.Length));
                msg.AddRange(Encoding.ASCII.GetBytes(Text));
            }
            return msg.ToArray();
        }

        public void GetData(byte[] msgBytes)
        {
            var bR = new BinaryReader(new MemoryStream(msgBytes));
            MessageType = (Type)bR.ReadInt32();
            var length = bR.ReadInt32();
            if (MessageType.Equals(Type.Image))
            {
                var imageData = bR.ReadBytes(length);
                bR.Close();
                var ms = new MemoryStream(imageData);
                Image1 = Image.FromStream(ms);
            }
            else
            {
                Text = Encoding.ASCII.GetString(bR.ReadBytes(length));
            }
        }
    }
}