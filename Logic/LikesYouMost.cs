using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public abstract class LikesYouMost
    {
	protected struct LikesYouMostHolder
	{
	    public string m_Id;
	    public int m_Sum;
	}

	public Dictionary<string, List<int>> Score { get; set; }

	protected LikesYouMostHolder m_LikesYouMost;

	protected KeyValuePair<string, List<int>> m_LikesYouMostDetails;

	public enum eFilter
	{
	    Likes,
	    Comments,
	    Tags,
	    TotalScore
	}

	public enum eSearch
	{
	    Albums,
	    Videos,
	    Posts
	}

	public LikesYouMost()
	{
	    m_LikesYouMost.m_Id = null;
	    m_LikesYouMost.m_Sum = -1;
	    Score = new Dictionary<string, List<int>>();
	}

	public abstract KeyValuePair<string, List<int>> FindWhoLikesYouMost(List<bool> i_Filter, List<bool> i_Search);

	protected void findScoreByVideos(List<bool> i_Filter)
	{
	    foreach (Video video in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Videos)
	    {
		if (i_Filter[(int)eFilter.Likes])
		{
		    foreach (User user in video.LikedBy)
		    {
			if (user != null)
			{
			    updateWhoLikesYouMost(user.Id, eFilter.Likes);
			}
		    }
		}

		if (i_Filter[(int)eFilter.Comments])
		{
		    foreach (Comment comment in video.Comments)
		    {
			if (comment.From != null)
			{
			    updateWhoLikesYouMost(comment.From.Id, eFilter.Comments);
			}
		    }
		}

		if (i_Filter[(int)eFilter.Tags] && video.Tags != null)
		{
		    foreach (TagInfo tag in video.Tags)
		    {
			if (tag.User != null)
			{
			    updateWhoLikesYouMost(tag.User.Id, eFilter.Tags);
			}
		    }
		}
	    }
	}

	private void updateWhoLikesYouMost(string i_Id, eFilter i_Filter)
	{
	    if (isFriend(i_Id))
	    {
		if (!Score.ContainsKey(i_Id))
		{
		    Score.Add(i_Id, new List<int> { 0, 0, 0, 0 });
		}

		Score[i_Id][(int)i_Filter]++;
		Score[i_Id][(int)eFilter.TotalScore]++;

		if (Score[i_Id][(int)eFilter.TotalScore] > m_LikesYouMost.m_Sum)
		{
		    m_LikesYouMost.m_Sum = Score[i_Id][(int)eFilter.TotalScore];
		    m_LikesYouMost.m_Id = i_Id;
		}
	    }
	}

	private bool isFriend(string i_Id)
	{
	    bool exists = false;
	    foreach (User user in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Friends)
	    {
		if (user.Id == i_Id)
		{
		    exists = true;
		    break;
		}
	    }

	    return exists;
	}

	protected void findScoreByAlbums(List<bool> i_Filter)
	{
	    foreach (Album album in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Albums)
	    {
		if (i_Filter[(int)eFilter.Likes])
		{
		    foreach (User user in album.LikedBy)
		    {
			if (user != null)
			{
			    updateWhoLikesYouMost(user.Id, eFilter.Likes);
			}
		    }
		}

		if (i_Filter[(int)eFilter.Comments])
		{
		    foreach (Comment comment in album.Comments)
		    {
			if (comment.From != null)
			{
			    updateWhoLikesYouMost(comment.From.Id, eFilter.Comments);
			}
		    }
		}
	    }
	}

	protected void findScoreByPosts(List<bool> i_Filter)
	{
	    foreach (Post post in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Posts)
	    {
		if (i_Filter[(int)eFilter.Likes])
		{
		    foreach (User user in post.LikedBy)
		    {
			if (user != null)
			{
			    updateWhoLikesYouMost(user.Id, eFilter.Likes);
			}
		    }
		}

		if (i_Filter[(int)eFilter.Comments])
		{
		    foreach (Comment comment in post.Comments)
		    {
			if (comment.From != null)
			{
			    updateWhoLikesYouMost(comment.From.Id, eFilter.Comments);
			}
		    }
		}

		if (i_Filter[(int)eFilter.Tags])
		{
		    foreach (User user in post.TaggedUsers)
		    {
			if (user != null)
			{
			    updateWhoLikesYouMost(user.Id, eFilter.Tags);
			}
		    }
		}
	    }
	}
    }
}