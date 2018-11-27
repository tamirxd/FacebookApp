using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public class ApplicationLogic
    {
	public static FBUserData UserData { get; set; }

	public const string k_AppID = "1913317005633549";

        public LoginResult LoggedInResult { get; set; }

        public User LoggedInUser { get; set; }

        public FriendsStatistics FriendsInfo { get; set; }

        public LikesYouMost LikesYouMostFriend { get; set; }
    }
}