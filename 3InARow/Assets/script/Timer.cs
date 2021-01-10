using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float Time;
    public int Secounds;
    public int Minutes;
    string TimerText;

    Text TimerNumber;

	// Use this for initialization
	void Start () {
        TimerNumber = GetComponent<Text>();
        Secounds = 0;
        Minutes = 0;
	}
	
	// Update is called once per frame
	void Update () {

        Secounds = (int)Time;

        if(Secounds >= 60)
        {
            Time = 0;
            Minutes++;
        }

        TimerNumber.text = string.Format("{0:0}:{1:00}", Minutes, Secounds);
    }
}
