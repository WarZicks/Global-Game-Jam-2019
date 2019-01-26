using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedItem : MonoBehaviour {

    public bool redCube = false;

    public bool doRefForCane = false;

    public RessourceManager my_RM;

    public AudioSource soundCollect;

    // Use this for initialization
    void Start () {
        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();

        soundCollect = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (redCube == true && Input.GetKeyDown(KeyCode.Return))
        {
            my_RM.AddRedItem();
            doRefForCane = true;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            soundCollect.Play();
            Destroy(gameObject, 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            redCube = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            redCube = false;
        }
    }
}
