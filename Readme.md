## Logger helper

This little utility can be used to centralize your logging and clear up log clutter in the console.

You can create a logger object for each category of logging that you want to do and then just call the public Log() function on the object from your objects that you assigned this logger to. 

As an example let's say you want to only log events for the objects in the player inventory system but silence your objects that handle player movement.

You can create 2 Logger objects, one for player movement logging and one for inventory logging. 

Have a serialized field for a Logger in every inventory related script and every script related to player movement. Any logging can then be done by caller the Logger.Log function.
See the Logtester class for clarity.

In the movement related objects assign one of your loggers and in the inventory related objects assign the other.

Now you can enable logging for each of these categories by just going to the logger for that category and setting the ShowLogs bool instead of going to each class and removing your Debug.Log statements, 



This utility also allows for you to set the colour your logs show up in the terminal and you can add a prefix to each log type to help filter for the logs you see.

I got the main idea for this from Jason Storey's video 	[title](https://www.youtube.com/watch?v=sh7f4K9Wbj8&list=WL&index=20)

Feel free to ad to this and improve it. 
I will be adding some visual debugging stuff soon to draw some widgets and rays  as needed.
