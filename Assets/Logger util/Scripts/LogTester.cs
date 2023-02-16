using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is used to test the Logger class and serves as an example of how to use this.
/// </summary>
public class LogTester : MonoBehaviour
{
    [SerializeField] Lifestories.Logger _logger; //Specify the logger you want to use here
    // Start is called before the first frame update
    void Start()
    {
        _logger.Log("This is a test",this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
