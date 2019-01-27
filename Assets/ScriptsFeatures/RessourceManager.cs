using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceManager : MonoBehaviour {

    public int redItem;
    public int blueItem;
    public int greenItem;

    public int wood;
    public int roche;
    public int woodPlus;
    public int rochePlus;

    public GameObject Aquarium;
    public GameObject Ballon;
    public GameObject FishingCane;

    public UIManager my_UIManager;

    // Use this for initialization
    void Start () {
        my_UIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void AddRedItem()
    {
        my_UIManager.RedItemUI();
        redItem++;
    }

    public void AddBlueItem()
    {
        my_UIManager.BlueItemUI();
        blueItem++;
    }

    public void AddGreenItem()
    {
        my_UIManager.GreenItemUI();
        greenItem++;
    }
}
