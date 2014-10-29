using UnityEngine;
using System.IO;
using UnityEditor;

public class Dialog : AbstractAppleScript
{
	static string icnsPath = Path.Combine (EditorApplication.applicationContentsPath, "Resources/UnityAppIcon.icns").Replace ("/", ":").Substring (1);
	const string defaultCommand = "display dialog \"{0}\" with title \"{1}\" default answer \"\" with icon file \"{2}\"";
	
	public static string DisplayAnswer (string title, string message)
	{
		return DisplayAnswer (title, message, icnsPath);
	}

	public static string DisplayAnswer (string title, string message, string icnsPath)
	{
		return script.Execute (string.Format (defaultCommand, message, title, icnsPath)).Replace ("button returned:OK, text returned:", "");
	}

	public static string DisplayPassword (string title, string message)
	{
		return DisplayPassword (title, message, icnsPath);
	}

	public static string DisplayPassword (string title, string message, string icnsPath)
	{
		return script.Execute (string.Format (defaultCommand + " with hidden answer", message, title, icnsPath)).Replace ("button returned:OK, text returned:", "");
	}
}
