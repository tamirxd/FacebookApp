using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;

namespace Ex03_Logic
{
    public sealed class FaceBookConnector
    {
	private static FaceBookConnector s_FaceBookConnection = null;

	private static object s_LockObject = new object();

	public LoginResult Connection { get; private set; }

	private FaceBookConnector()
	{
	}

	public static FaceBookConnector LogOut()
	{
	    FacebookService.Logout(() => { });
	    s_FaceBookConnection = null;
	    return s_FaceBookConnection;
	}

	public static FaceBookConnector ConnectToFacebookAPI(string i_AccessToken)
	{
	    if (s_FaceBookConnection == null)
	    {
		lock (s_LockObject)
		{
		    if (s_FaceBookConnection == null)
		    {
			s_FaceBookConnection = new FaceBookConnector();
			s_FaceBookConnection.Connection = FacebookService.Connect(i_AccessToken);
		    }
		}
	    }

	    return s_FaceBookConnection;
	}

	public static FaceBookConnector GetFacebookConnection()
	{
	    if (s_FaceBookConnection == null)
	    {
		lock (s_LockObject)
		{
		    if (s_FaceBookConnection == null)
		    {
			s_FaceBookConnection = new FaceBookConnector();
			s_FaceBookConnection.Connection = FacebookService.Login(
			    ApplicationLogic.k_AppID,
			    "public_profile",
			    "email",
			    "user_birthday",
			    "user_likes",
			    "user_hometown",
			    "user_location",
			    "user_friends",
			    "user_posts",
			    "user_photos",
			    "user_events");
		    }
		}
	    }

	    return s_FaceBookConnection;
	}

	public string GetAccsessToken()
	{
	    string accessToken = null;
	    if (s_FaceBookConnection != null)
	    {
		accessToken = s_FaceBookConnection.Connection.AccessToken;
	    }

	    return accessToken;
	}
    }
}