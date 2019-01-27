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

    public GameObject respawnPoint;
    public GameObject player;
    public PlayerMovement my_PM;

    public Animator animFade;

	// Use this for initialization
	void Start () {

        timesUp.SetActive(false);
        TimerBar = GetComponent<Image>();
        timeLeft = maxTime;

        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();
        my_Lac = GameObject.FindGameObjectWithTag("Lac").GetComponent<Lac>();
        player = GameObject.FindGameObjectWithTag("Player");
        respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
        my_PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
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
                my_PM.disableInput = true;
                LoseItems();
                StartCoroutine(Dead());
                //Death();
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

    /*void Death()
    {
        player.transform.position = respawnPoint.transform.position;
        my_PM.disableInput = false;
    }*/

    IEnumerator Dead()
    {
        my_PM.disableInput = true;
        animFade.SetBool("DoFade", true);
        yield return new WaitForSeconds(0.4f);
        player.transform.position = respawnPoint.transform.position;
        yield return new WaitForSeconds(3.6f);
        animFade.SetBool("DoFade", false);
        my_PM.disableInput = false;
    }
}
