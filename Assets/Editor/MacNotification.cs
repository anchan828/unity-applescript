using UnityEngine;
using System.Collections;

public class MacNotificationService : AbstractAppleScript
{


	public static void ShowNotification (string text)
	{
		script.Execute ("display notification \"" + text + "\"");
	}

	public static void ShowNotification (string text, string title)
	{
		script.Execute ("display notification \"" + text + "\" with title \"" + title + "\"");
	}

	public static void ShowNotification (string text, string title, string subTitle)
	{
		script.Execute ("display notification \"" + text + "\" with title \"" + title + "\" subtitle \"" + subTitle + "\"");
	}

	public static void ShowNotification (string text, string title, string subTitle, string soundName)
	{
		script.Execute ("display notification \"" + text + "\" with title \"" + title + "\" subtitle \"" + subTitle + "\" sound name \"" + soundName + "\"");
	}


}
