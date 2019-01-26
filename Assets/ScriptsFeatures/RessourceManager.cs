using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceManager : MonoBehaviour {

    public int redItem;
    public int blueItem;
    public int greenItem;

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
        redItem++;
        my_UIManager.RedItemUI();
    }

    public void AddBlueItem()
    {
        blueItem++;
        my_UIManager.BlueItemUI();
    }

    public void AddGreenItem()
    {
        greenItem++;
        my_UIManager.GreenItemUI();
    }
}
