using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endurance : MonoBehaviour {

    Image EnduranceBar;
    public float maxEndu;
    public float enduLeft;
    public bool CanRun = false;
    public bool HaveEndu = true;

	// Use this for initialization
	void Start () {
        maxEndu = 150f*Time.deltaTime;
        EnduranceBar = GetComponent<Image>();      
        //enduLeft = maxEndu;
	}
	
	// Update is called once per frame
	void Update () {

        EnduranceBar.fillAmount = enduLeft / maxEndu;

        if (Input.GetKey(KeyCode.LeftShift) && CanRun == true)
        {
            if (enduLeft > 0)
            {
                enduLeft -= Time.deltaTime;
                HaveEndu = true;
            }
            else
            {
                HaveEndu = false;
            }
        }

    }
}
