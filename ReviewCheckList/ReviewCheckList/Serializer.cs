using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace ReviewCheckList
{
    class Serializer: Form
    {
        public Serializer()
        {

        }
        //-------------------------------------SERIALIZE---------------------------------------------
        public void Serialize(string path,string fileName)
        {
            List<ItemProperties> lstItems = MainUI.lstItems;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ItemProperties>));
            string filePath = $@"{path}\{fileName}_ItemInfo.xml";
            if (File.Exists(filePath))
            {
                var attributes = File.GetAttributes(filePath);
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    attributes &= ~FileAttributes.Hidden;
                    File.SetAttributes(filePath, attributes);
                }

            }
            using (FileStream pathh = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(pathh, lstItems);
            }

            File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
        }
        public void ListSerialize(List<string> lst,string path, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));
            string filePath = $@"{path}\{fileName}.xml";
            using (FileStream pathh = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(pathh, lst);
            }

        }
        //-------------------------------------DESERIALIZE---------------------------------------------
        public void DeSerialize(string path, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ItemProperties>));
            string filePath = $@"{path}\{fileName}_ItemInfo.xml";
            using (FileStream pathh = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                MainUI.lstItems = xmlSerializer.Deserialize(pathh) as List<ItemProperties>;
                //MessageBox.Show("Done");
            }
        }
        public void ListDeSerialize(string path, string fileName)
        {
            List<string> infoList = new List<string>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));
            string filePath = $@"{path}\{fileName}.xml";
            using (FileStream pathh = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                infoList = xmlSerializer.Deserialize(pathh) as List<string>;
            }
            for (int it = 0; it <= 9; it++)
            {
                MainUI.header.Add(infoList[it]);
            }
            //info.InsertRange(1, infoList);
            for (int item = 11; item <= infoList.Count - 1; item++)
            {
                MainUI.items.Add(infoList[item]);
            }

        }

        public void Comment()
        {
            
        }


    }
}
