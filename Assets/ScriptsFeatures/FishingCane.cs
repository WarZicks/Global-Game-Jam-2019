using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingCane : MonoBehaviour {

    public bool FishCaneOn = false;

    public bool lvl1Fish = false;
    public bool lvl2Fish = false;
    public bool lvl3Fish = false;

    public Sprite SkinCane1;
    public Sprite SkinCane2;
    public Sprite SkinCane3;

    // Use this for initialization
    void Start () {
        FishCaneOn = true;
        lvl1Fish = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (lvl1Fish == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SkinCane1;
        }
        if (lvl2Fish == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SkinCane2;
        }
        if (lvl3Fish == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SkinCane3;
        }
    }
}
