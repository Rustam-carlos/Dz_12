using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Dz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerialiser = new XmlSerializer(typeof(Tank));
            File.Create("D:/1/1.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            using (var stream = File.Open(@"D:/1/1.bin", FileMode.Truncate))
            {
                var tank = new Tank
                {
                    type = "Tiger H1",
                    ammunition = 250,
                    armor = 680,
                    mobility = 40
                };
                serializer.Serialize(stream, tank);
            }
            using (var stream = File.Open(@"D:/1/1.bin", FileMode.Truncate))
            {
                var tank2 = new Tank
                {
                    type = "Tiger P2",
                    ammunition = 250,
                    armor = 680,
                    mobility = 40
                };
                string data = JsonConvert.SerializeObject(tank2);
                Tank result = JsonConvert.DeserializeObject<Tank>(data);
            }
        }
    }
}
