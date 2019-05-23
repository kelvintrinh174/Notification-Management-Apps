# Notification-Management-Apps
WinForms Application, Regular Expression, Delegate

Purpose: In the real world, the notification management system consists of two parts, one is to allow clients to subscribe/unsubscribe the notification, and another part is to facilitate administrator(s) to publish the notification. This application simplifies the problem, and merges two parts as one.  This C# application to mimic notification management system. 

The app facilitates clients to subscribe/unsubscribe notification as well as send notification to all subscribers.  This app make sure that the provided email address is valid and provided cell phone number is followed the specified format. 
After the app has been launched, following GUI (or similar one) should be presented. 
![image](https://user-images.githubusercontent.com/39202933/58254569-0743c300-7d39-11e9-9161-e6dba5fd169a.png)

After Manage Subscription button clicked, following GUI (or similar one) should be popped up to allow clients to subscribe or unsubscribe notification. 

![image](https://user-images.githubusercontent.com/39202933/58254642-2cd0cc80-7d39-11e9-8b31-311e431608ca.png)

If an invalid email address has been provided, error message should be provided.
![image](https://user-images.githubusercontent.com/39202933/58254732-61dd1f00-7d39-11e9-9220-cf9cd8aea9f4.png)

After Publish Notification button clicked, following GUI will be presented to facilitate notification publish. 
![image](https://user-images.githubusercontent.com/39202933/58254845-a799e780-7d39-11e9-96b8-a38ae2b1f846.png)

This app is able to deal with multiple subscribers by using generic collections to hold the subscribers’ information.
