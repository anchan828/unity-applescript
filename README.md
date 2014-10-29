unity-applescript
=================

通知
--------------------

```cs
MacNotificationService.ShowNotification ("test", "title", "subtitle", "good");
```


ダイアログ
--------------------


```cs
var icns = "Users:keigo:Desktop:Twitter_logo_blue.png";

var userID = Dialog.DisplayAnswer (title, "IDを入力してください", icns);
var password = Dialog.DisplayPassword (title, "パスワードを入力してください", icns);
```
