using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ex03_Logic;

namespace Ex03_UI
{
    public partial class FormFriendsStatistics : Form
    {
	public ApplicationLogic Logic { get; private set; }

	public FormFriendsStatistics(ApplicationLogic i_Logic)
	{
	    Logic = i_Logic;
	    InitializeComponent();
	    updateInformation();
	}

	private void updateInformation()
	{
	    try
	    {
		checkIfFriendsAvailable();
		checkIfPercentageAvailable();
		List<KeyValuePair<string, int>> topFriendsLike = Logic.FriendsInfo.GetFriendLikes();

		foreach (KeyValuePair<string, int> friend in topFriendsLike)
		{
		    ListViewItem listViewItem = new ListViewItem(friend.Key);
		    listViewItem.SubItems.Add(friend.Value.ToString());
		    ListViewTopLikers.Invoke(new Action(() => ListViewTopLikers.Items.Add(listViewItem)));
		}

		List<KeyValuePair<string, DateTime>> friendsBirthdays =
		    Logic.FriendsInfo.GetFriendsBirthdays();
		foreach (KeyValuePair<string, DateTime> friend in friendsBirthdays)
		{
		    ListViewItem listViewItem = new ListViewItem(friend.Key);
		    listViewItem.SubItems.Add(friend.Value.ToShortDateString());
		    ListViewBirthdayFriends.Invoke(new Action(() => ListViewBirthdayFriends.Items.Add(listViewItem)));
		}
	    }
	    catch (Exception)
	    {
	    }
	}

	private void checkIfFriendsAvailable()
	{
	    if (!string.IsNullOrEmpty(Logic.FriendsInfo.FriendsNumber.ToString()))
	    {
		labelFriendsNumberCount.Text = Logic.FriendsInfo.FriendsNumber.ToString();
	    }
	    else
	    {
		labelFriendsNumberCount.Text = "No friends available!";
	    }
	}

	private void checkIfPercentageAvailable()
	{
	    if (!string.IsNullOrEmpty(Logic.FriendsInfo.MaleFemalePrecent.ToString()))
	    {
		labelMaleFemaleCount.Text = Logic.FriendsInfo.MaleFemalePrecent.ToString();
	    }
	    else
	    {
		labelMaleFemaleCount.Text = "Percentage for friends is not avilable!";
	    }
	}
    }
}