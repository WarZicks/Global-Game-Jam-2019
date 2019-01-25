using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    Image TimerBar;
    public float maxTime = 5f;
    public float timeLeft;
    public GameObject timesUp;
    public bool InHome;

	// Use this for initialization
	void Start () {

        timesUp.SetActive(false);
        TimerBar = GetComponent<Image>();
        timeLeft = maxTime;

	}
	
	// Update is called once per frame
	void Update () {

        TimerBar.fillAmount = timeLeft / maxTime;

        if (InHome == false)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                
            }
            else
            {
                timesUp.SetActive(true);
                Time.timeScale = 0;
            }
        }
	}
}
