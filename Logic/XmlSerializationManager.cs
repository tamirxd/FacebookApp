using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ex03_Logic
{
    public class XmlSerializationManager : SerializationManager
    {
	public override object Load(object i_ObjectToLoadFrom)
	{
	    object res = new object();
	    string xmlFilePath = Directory.GetCurrentDirectory() + @"\\" + i_ObjectToLoadFrom.GetType().Name + ".xml";

	    if (File.Exists(xmlFilePath) && new FileInfo(xmlFilePath).Length != 0)
	    {
		using (Stream xmlStream = new FileStream(xmlFilePath, FileMode.Open))
		{
		    XmlSerializer xmlSerializer = new XmlSerializer(i_ObjectToLoadFrom.GetType());
		    res = xmlSerializer.Deserialize(xmlStream);
		}
	    }

	    return res;
	}

	public override void Save(object i_ObjectToSaveTo)
	{
	    string xmlFilePath = Directory.GetCurrentDirectory() + @"\\" + i_ObjectToSaveTo.GetType().Name + ".xml";

	    if (File.Exists(xmlFilePath) && new FileInfo(xmlFilePath).Length != 0)
	    {
		File.Delete(xmlFilePath);
	    }

	    using (Stream xmlStream = new FileStream(xmlFilePath, FileMode.OpenOrCreate))
	    {
		XmlSerializer xmlSerializer = new XmlSerializer(i_ObjectToSaveTo.GetType());
		xmlSerializer.Serialize(xmlStream, i_ObjectToSaveTo);
	    }
	}
    }
}