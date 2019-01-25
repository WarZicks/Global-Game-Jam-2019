using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject myGameObjectText;
    public Text myText;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void RedItemUI()
    {
        myText.text = "Red Item Collected";
        myGameObjectText.SetActive(true);
    }

    public void BlueItemUI()
    {
        myText.text = "Blue Item Collected";
        myGameObjectText.SetActive(true);
    }

    public void GreenItemUI()
    {
        myText.text = "Green Item Collected";
        myGameObjectText.SetActive(true);
    }
}
