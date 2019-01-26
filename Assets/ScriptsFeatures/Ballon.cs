using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour {

    public bool BallonOn = false;
    public int PlayBall = 0;

    public bool lvl1Endu = false;
    public bool lvl2Endu = false;
    public bool lvl3Endu = false;

    public bool inTrigger = false;

    // Use this for initialization
    void Start () {
        BallonOn = true;
        lvl1Endu = true;
        GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().CanRun=true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true)
        {
            Debug.Log("Playing");
            PlayBall++;

            if (PlayBall == 3)
            {
                if (lvl1Endu == true)
                {
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu += 50f * Time.deltaTime;
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft += 50f * Time.deltaTime;
                }
                else if (lvl2Endu == true)
                {
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu += 100f * Time.deltaTime;
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft += 100f * Time.deltaTime;
                }
                else if (lvl3Endu == true)
                {
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu += 150f * Time.deltaTime;
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft += 150f * Time.deltaTime;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }
}
