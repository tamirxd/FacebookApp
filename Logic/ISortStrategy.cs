using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public interface ISortStrategy
    {
	bool Swap(User i_User1, User i_User2);
    }
}
