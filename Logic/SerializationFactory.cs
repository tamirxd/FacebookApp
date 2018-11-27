using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Logic
{
    public static class SerializationFactory
    {
	public enum eSerializeTypes
	{
	    XmlSerialize,
	}

	public static SerializationManager CreateSerializationManager(eSerializeTypes i_SerializationType)
	{
	    switch (i_SerializationType)
	    {
		case eSerializeTypes.XmlSerialize:
		    return new XmlSerializationManager();
		default:
		    throw new Exception("Unimplented serialization type");
	    }
	}
    }
}