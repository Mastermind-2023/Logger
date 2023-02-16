using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
/*
* Thank you Jason Storey
* https://www.youtube.com/watch?v=sh7f4K9Wbj8&list=WL&index=20
* for this idea and most of the code.
*/

namespace Lifestories // Feel free to remove or change the namespace to suit your project
{
    /// <summary>
    /// Logger helper class used to organise and color code logging in your app.
    /// You can add a logger for each category of logging that you want to do.
    /// </summary>
    public class Logger : MonoBehaviour
    {


        [Header("Settings")]
        [SerializeField]
        [Tooltip("Will only show logs or if set to true")]
        bool _showLogs; 
        [SerializeField]
        [Tooltip("Add a prefix to make searching your logs for specific event types easier.")]
        string _prefix; 
      
        //TODO: Check if the color formatting code affects logging when not running in Unity Editor
        [SerializeField]
        [Tooltip("Choose a colour for your items to be logged in the unity console")]
        Color _prefixColor ;
        private string _hexColor;

        // Start is called before the first frame update
        private void OnValidate()
        {
            _hexColor = "#" + ColorUtility.ToHtmlStringRGB(_prefixColor);
          
        }

        public void Log(object message, Object sender)
        {
            if (!_showLogs) return;

          
            Color color = _prefixColor;
            Debug.Log(string.Format("<color=#{0:X2}{1:X2}{2:X2}>{3}</color>", (byte)(color.r * 255f), (byte)(color.g * 255f), (byte)(color.b * 255f),_prefix + message + 
                " sent by " + sender.name ),sender);
        }
    
    }
}
