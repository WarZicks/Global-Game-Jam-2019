using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour {

    public bool BallonOn = false;

	// Use this for initialization
	void Start () {
        BallonOn = true;
        GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().CanRun=true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Playing");
            GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu++;
            GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft++;
        }
    }
}
