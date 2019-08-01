using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SiriDsiri
{
    [Serializable]
    public class Tutorial
    {
        public int TutorialId;
        public string TutorialName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.TutorialId = 1;
            tutorial.TutorialName = "MultiPurpose";

            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Sridhar\serialize.txt", FileMode.Create, FileAccess.Write);
            formater.Serialize(stream, tutorial);

            stream.Close();

            stream = new FileStream(@"C:\Sridhar\serialize.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formater.Deserialize(stream);

            Console.WriteLine(objnew.TutorialId);
            Console.WriteLine(objnew.TutorialName);

            Console.ReadKey();
        }
    }
}
