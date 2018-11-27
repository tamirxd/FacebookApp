using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Ex03_Logic
{
    public class FriendsStatistics
    {
	public FacebookObjectCollection<User> FriendList { get; private set; }

	public string SinglePercent { get; private set; }

	public string MaleFemalePrecent { get; private set; }

	private ApplicationLogic Logic { get; }

	public int FriendsNumber { get; }

	public FriendsStatistics(ApplicationLogic i_Logic)
	{
	    Logic = i_Logic;
	    setSinglePercent();
	    setMaleAndFemalePrecent();
	    FriendList = Logic.LoggedInUser.Friends;
	    FriendsNumber = Logic.LoggedInUser.Friends.Count;
	}

	private void setSinglePercent()
	{
	    SinglePercent = null;
	    float attendingSingle = 0;
	    try
	    {
		foreach (User attendingUser in FriendList)
		{
		    if (attendingUser.RelationshipStatus == User.eRelationshipStatus.Single)
		    {
			attendingSingle++;
		    }
		}

		if (FriendList.Count != 0)
		{
		    SinglePercent = string.Format(@"{0:0.#}%", (attendingSingle / FriendList.Count) * 100f);
		}
	    }
	    catch (Exception)
	    {
	    }
	}

	private void setMaleAndFemalePrecent()
	{
	    float maleCount = 0;
	    MaleFemalePrecent = null;
	    try
	    {
		foreach (User friend in FriendList)
		{
		    if (friend.Gender == User.eGender.male)
		    {
			maleCount++;
		    }
		}

		MaleFemalePrecent =
		    string.Format(
			@"{0:0.#}%/{1:0.#}",
		    maleCount / FriendList.Count * 100f,
			100 - (maleCount / FriendList.Count * 100f));
	    }
	    catch (Exception)
	    {
	    }
	}

	public List<KeyValuePair<string, DateTime>> GetFriendsBirthdays()
	{
	    List<KeyValuePair<string, DateTime>> friendsBirthdays;
	    Dictionary<string, DateTime> friendsBirthdaysDict = new Dictionary<string, DateTime>();
	    foreach (User user in Logic.LoggedInUser.Friends)
	    {
		friendsBirthdaysDict.Add(user.Name, DateTime.Parse(user.Birthday));
	    }

	    friendsBirthdays = friendsBirthdaysDict.ToList();
	    friendsBirthdays.Sort(delegate(KeyValuePair<string, DateTime> pair1, KeyValuePair<string, DateTime> pair2)
	    {
		DateTime nowDate = DateTime.Now;
		DateTime firstDateToCompare = new DateTime(nowDate.Year, pair1.Value.Month, pair1.Value.Day);
		DateTime secondDateToCompare = new DateTime(nowDate.Year, pair2.Value.Month, pair2.Value.Day);

		if (firstDateToCompare.CompareTo(nowDate) < 0)
		{
		    firstDateToCompare = firstDateToCompare.AddYears(1);
		}

		if (secondDateToCompare.CompareTo(nowDate) < 0)
		{
		    secondDateToCompare = secondDateToCompare.AddYears(1);
		}

		TimeSpan t1 = nowDate - firstDateToCompare;
		TimeSpan t2 = nowDate - secondDateToCompare;
		return t2.Days - t1.Days;
	    });

	    return friendsBirthdays;
	}

	public List<KeyValuePair<string, int>> GetFriendLikes()
	{
	    Dictionary<string, int> FriendsLikesDictionary = new Dictionary<string, int>();
	    foreach (Post post in Logic.LoggedInUser.Posts)
	    {
		if (Logic.LoggedInUser.Name == post.From.Name)
		{
		    foreach (User user in post.LikedBy)
		    {
			if (FriendsLikesDictionary.ContainsKey(user.Name))
			{
			    FriendsLikesDictionary[user.Name]++;
			}
			else
			{
			    FriendsLikesDictionary.Add(user.Name, 1);
			}
		    }
		}
	    }

	    List<KeyValuePair<string, int>> friendsLikes = FriendsLikesDictionary.ToList();
	    friendsLikes.Sort((i_Pair1, i_Pair2) => i_Pair2.Value.CompareTo(i_Pair1.Value));
	    return friendsLikes;
	}
    }
}