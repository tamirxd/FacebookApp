using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public class AscendingSorter : ISortStrategy
    {
	public bool Swap(User i_User1, User i_User2)
	{
	    if (i_User1.Name.CompareTo(i_User2.Name) > 0)
	    {
		return true;
	    }
	    else
	    {
		return false;
	    }
	}
    }
}
