using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenItem : MonoBehaviour {

    public bool greenCube = false;

    public RessourceManager my_RM;

    // Use this for initialization
    void Start()
    {
        my_RM = GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (greenCube == true && Input.GetKeyDown(KeyCode.Return))
        {
            my_RM.AddGreenItem();
            Destroy(gameObject);
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
