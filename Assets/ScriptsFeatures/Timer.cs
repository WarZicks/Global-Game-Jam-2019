using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public RessourceManager my_RM;
    public Lac my_Lac;

    Image TimerBar;
    public float maxTime;
    public float timeLeft;
    public GameObject timesUp;
    public bool InHome;

	// Use this for initialization
	void Start () {

        timesUp.SetActive(false);
        TimerBar = GetComponent<Image>();
        timeLeft = maxTime;

        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();
        my_Lac = GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>();
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
                LoseItems();
            }
        }
	}

    void LoseItems()
    {
        my_Lac.fish = 0;
        my_Lac.superFish = 0;
        my_Lac.gigaFish = 0;
        my_RM.redItem = 0;
        my_RM.blueItem = 0;
        my_RM.greenItem = 0;
    }
}
