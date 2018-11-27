using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public class FBUserData
    {
	public LinkedList<Event> Events { get; set; }

	public LinkedList<Page> Pages { get; set; }

	public LinkedList<Album> Albums { get; set; }

	public LinkedList<Checkin> Checkins { get; set; }

	public LinkedList<Post> Posts { get; set; }

	public List<User> Friends { get; set; }

	public FBUserData()
	{
	    Albums = new LinkedList<Album>();
	    Events = new LinkedList<Event>();
	    Pages = new LinkedList<Page>();
	    Checkins = new LinkedList<Checkin>();
	    Posts = new LinkedList<Post>();
	    Friends = new List<User>();
	    FetchAllData();
	}

	public void FetchAllData()
	{
	    FetchAlbums();
	    FetchCheckIns();
	    FetchPosts();
	    FetchEvents();
	    FetchPages();
	    FetchFriends();
	}

	public void FetchFriends()
	{
	    foreach (User friend in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Friends)
	    {
		Friends.Add(friend);
	    }
	}

	public void FetchAlbums()
	{
	    foreach (Album album in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Albums)
	    {
		Albums.AddLast(album);
	    }
	}

	public void FetchPosts()
	{
	    foreach (Post post in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Posts)
	    {
		Posts.AddLast(post);
	    }
	}

	public void FetchPages()
	{
	    foreach (Page page in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.LikedPages)
	    {
		Pages.AddLast(page);
	    }
	}

	public void FetchEvents()
	{
	    foreach (Event evnt in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Events)
	    {
		Events.AddLast(evnt);
	    }
	}

	public void FetchCheckIns()
	{
	    foreach (Checkin check in FaceBookConnector.GetFacebookConnection().Connection.LoggedInUser.Checkins)
	    {
		Checkins.AddLast(check);
	    }
	}
    }
}