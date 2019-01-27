using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodPlus : MonoBehaviour
{

    public bool inTrigger = false;

    public AudioSource soundCollectItem;
    public UIManager my_UIManager;

    // Use this for initialization
    void Start()
    {
        soundCollectItem = GetComponent<AudioSource>();
        my_UIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true)
        {
            GameObject.FindGameObjectWithTag("RessourceManager").GetComponent<RessourceManager>().woodPlus++;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            soundCollectItem.Play();
            my_UIManager.RareWoodItemUI();
            Destroy(gameObject, 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }
}
