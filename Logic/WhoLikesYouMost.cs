using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Logic
{
    public class WhoLikesYouMost : LikesYouMost
    {
	public override KeyValuePair<string, List<int>> FindWhoLikesYouMost(List<bool> i_Filter, List<bool> i_Search)
	{
	    Score.Clear();
	    m_LikesYouMost.m_Id = null;
	    m_LikesYouMost.m_Sum = -1;

	    if (i_Search[(int)eSearch.Posts])
	    {
		findScoreByPosts(i_Filter);
	    }

	    if (i_Search[(int)eSearch.Videos])
	    {
		findScoreByVideos(i_Filter);
	    }

	    if (i_Search[(int)eSearch.Albums])
	    {
		findScoreByAlbums(i_Filter);
	    }

	    if (m_LikesYouMost.m_Id != null && Score.ContainsKey(m_LikesYouMost.m_Id))
	    {
		m_LikesYouMostDetails = new KeyValuePair<string, List<int>>(m_LikesYouMost.m_Id, Score[m_LikesYouMost.m_Id]);
	    }
	    else
	    {
		m_LikesYouMostDetails = new KeyValuePair<string, List<int>>(null, null);
	    }

	    return m_LikesYouMostDetails;
	}
    }
}
