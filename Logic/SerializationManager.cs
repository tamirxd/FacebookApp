using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Logic
{
    public abstract class SerializationManager
    {
	public abstract object Load(object i_ObjToLoad);

	public abstract void Save(object i_ObjToSave);
    }
}