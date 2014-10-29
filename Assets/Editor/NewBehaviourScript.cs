using UnityEngine;
using System.Collections;
using UnityEditor;

//[InitializeOnLoad]
public class NewBehaviourScript
{
	static NewBehaviourScript ()
	{
		MacNotificationService.ShowNotification ("test", "title", "subtitle", "good");
		var title = "Twitterログイン";
		var icns = "Users:keigo:Desktop:Twitter_logo_blue.png";

		var userID = Dialog.DisplayAnswer (title, "IDを入力してください", icns);
		var password = Dialog.DisplayPassword (title, "パスワードを入力してください", icns);
		Debug.Log (userID + " : " + password);
	}
}
