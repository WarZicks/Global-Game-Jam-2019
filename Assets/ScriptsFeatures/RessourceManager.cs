using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Text Txt_Wood, Txt_Stone, Txt_WoodPlus, Txt_StonePlus;

    // Use this for initialization
    void Start () {
        my_UIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        UpdateNumberWoodTxt();
        UpdateNumberWoodPlusTxt();
        UpdateNumberStoneTxt();
        UpdateNumberStonePlusTxt();
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

    public void UpdateNumberWoodTxt()
    {
        Txt_Wood.text = "x " + wood.ToString();
    }

    public void UpdateNumberWoodPlusTxt()
    {
        Txt_WoodPlus.text = "x " + woodPlus.ToString();
    }

    public void UpdateNumberStoneTxt()
    {
        Txt_Stone.text = "x " + roche.ToString();
    }

    public void UpdateNumberStonePlusTxt()
    {
        Txt_StonePlus.text = "x " + rochePlus.ToString();
    }
}
