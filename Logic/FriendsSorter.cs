using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public class FriendsSorter
    {
	public ISortStrategy SortStrategy { get; set; }

	public void Sort()
	{
	    int idxA = 0, idxB = 0;

	    for (int i = 0; i < ApplicationLogic.UserData.Friends.Count; i++)
	    {
		for (int j = 0; j < ApplicationLogic.UserData.Friends.Count; j++)
		{
		    if (SortStrategy.Swap(ApplicationLogic.UserData.Friends[i], ApplicationLogic.UserData.Friends[j]))
		    {
			swap(ApplicationLogic.UserData.Friends, idxA, idxB);
		    }

		    idxB++;
		}

		idxA++;
		idxB = 0;
	    }
	}

	private void swap<T>(List<T> i_List, int i_indexA, int i_indexB)
	{
	    T tmp = i_List[i_indexA];
	    i_List[i_indexA] = i_List[i_indexB];
	    i_List[i_indexB] = tmp;
	}
    }
}
