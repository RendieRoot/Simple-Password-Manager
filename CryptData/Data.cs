using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Net.NetworkInformation;

namespace CryptData
{
    public class Data
    {
        public static Data GetData()
        {
            Data data = null;
            string filename = Global.SaveFile;

            if (File.Exists(filename))
            {
                using (FileStream fl = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Data));
                    data = (Data)xs.Deserialize(fl);
                    fl.Close();
                }
            }
            else data = new Data();

            return data;


        }

        public void Save()
        {
            string filename = Global.SaveFile;

            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream fl = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Data));
                xs.Serialize(fl, this);
                fl.Close();
            }
        }

        public string data { get; set; }
    }

    public class Key
    {
        public static Key GetKey()
        {
            Key key = null;
            string filename = Global.SaveSettings;

            if (File.Exists(filename))
            {
                using (FileStream fl = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Key));
                    key = (Key)xs.Deserialize(fl);
                    fl.Close();
                }
            }
            else key = new Key();

            return key;
        }

        public static Key GetProtect()
        {
            Key protect = null;
            string filename = Global.SaveSettings;

            if (File.Exists(filename))
            {
                using (FileStream fl = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Key));
                    protect = (Key)xs.Deserialize(fl);
                    fl.Close();
                }
            }
            else protect = new Key();

            return protect;
        }

        public void Save()
        {
            string filename = Global.SaveSettings;

            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream fl = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Key));
                xs.Serialize(fl, this);
                fl.Close();
            }
        }

        public void SaveProtect()
        {
            string filename = Global.SaveSettings;

            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream fl = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Key));
                xs.Serialize(fl, this);
                fl.Close();
            }
        }

        public string data { get; set; }
        public string protect { get; set; }
    }

    public class Mac
    {
        public static string GetMac()
        {
            string macAddress = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddress += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddress;
        }
    }
}