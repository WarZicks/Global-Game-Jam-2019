using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenItem : MonoBehaviour {

    public bool greenCube = false;

    public bool doRefForCane = false;

    public RessourceManager my_RM;

    public AudioSource soundCollect;

    // Use this for initialization
    void Start()
    {
        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();

        soundCollect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (greenCube == true && Input.GetKeyDown(KeyCode.Return))
        {
            my_RM.AddGreenItem();
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
            greenCube = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            greenCube = false;
        }
    }
}
