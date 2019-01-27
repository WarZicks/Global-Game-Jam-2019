using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject myGameObjectText;
    public Text myText;
    public GameObject imageNewt;
    public GameObject nameNewt;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void RedItemUI()
    {
        myText.text = "A new thing to put in my house !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());

    }

    public void BlueItemUI()
    {
        myText.text = "A new thing to put in my house !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void GreenItemUI()
    {
        myText.text = "A new thing to put in my house !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void WoodItemUI()
    {
        myText.text = "Yes a stick !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void RareWoodItemUI()
    {
        myText.text = "Yay a rare stick !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void DarkRockItemUI()
    {
        myText.text = "Yes a dark stone !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void GoldRockItemUI()
    {
        myText.text = "Yay a golden stone !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void StandardFishItemUI()
    {
        myText.text = "Yes I caught a fish !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void RareFishItemUI()
    {
        myText.text = "Yay I caught a rare fish!";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    public void GoldFishItemUI()
    {
        myText.text = "Ouah it's a golden fish !";
        myGameObjectText.SetActive(true);
        imageNewt.SetActive(true);
        nameNewt.SetActive(true);
        StartCoroutine(TimeToDisable());
    }

    IEnumerator TimeToDisable()
    {
        yield return new WaitForSeconds(2f);
        myGameObjectText.SetActive(false);
        imageNewt.SetActive(false);
        nameNewt.SetActive(false);
    }
}
