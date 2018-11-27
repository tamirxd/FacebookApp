using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ex03_Logic
{
    public class AppSettings
    {
	public Point LastWindowLocation { get; set; }

	public Size LastWindowSize { get; set; }

	public bool RememberUser { get; set; }

	public string LastAccessToken { get; set; }

	private const string k_SettingsFileSuffix = @"\\FBAppSettings.xml";

	public AppSettings()
	{
	    LastWindowLocation = new Point(50, 50);
	    LastWindowSize = new Size(1200, 500);
	    RememberUser = false;
	    LastAccessToken = null;
	}

	public void SaveToFile()
	{
	    ClearSavedSettings();
	    using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SettingsFileSuffix, FileMode.OpenOrCreate))
	    {
		XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
		serializer.Serialize(xmlStream, this);
	    }
	}

	public void ClearSavedSettings()
	{
	    if (File.Exists(Directory.GetCurrentDirectory() + k_SettingsFileSuffix)
	    && new FileInfo(Directory.GetCurrentDirectory() + @"\FBAppSettings.xml").Length != 0)
	    {
		File.Delete(Directory.GetCurrentDirectory() + k_SettingsFileSuffix);
	    }
	}
    }
}