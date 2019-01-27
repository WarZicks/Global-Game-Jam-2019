using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingCane : MonoBehaviour {

    public bool FishCaneOn = false;

    public bool lvl1Fish = false;
    public bool lvl2Fish = false;
    public bool lvl3Fish = false;

    // Use this for initialization
    void Start () {
        FishCaneOn = true;
        lvl1Fish = true;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
