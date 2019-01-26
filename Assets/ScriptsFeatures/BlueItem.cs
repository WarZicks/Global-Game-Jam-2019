using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueItem : MonoBehaviour {

    public bool blueCube = false;

    public bool doRefForBalloon = false;

    public RessourceManager my_RM;

    // Use this for initialization
    void Start()
    {
        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (blueCube == true && Input.GetKeyDown(KeyCode.Return))
        {
            my_RM.AddBlueItem();
            doRefForBalloon = true;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            blueCube = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            blueCube = false;
        }
    }
}
