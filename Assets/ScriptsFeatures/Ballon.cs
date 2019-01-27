using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour {

    public bool BallonOn = false;
    public int PlayBall = 0;

    public bool lvl1Endu = false;
    public bool lvl2Endu = false;
    public bool lvl3Endu = false;

    public bool inTrigger = false;

    public AudioSource soundPlayBall;

    public PlayerMovement my_PM;

    public Sprite SkinBallon1;
    public Sprite SkinBallon2;
    public Sprite SkinBallon3;

    // Use this for initialization
    void Start () {
        BallonOn = true;
        lvl1Endu = true;
        GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().CanRun=true;

        soundPlayBall = GetComponent<AudioSource>();

        my_PM = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update () {

        if (lvl1Endu == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SkinBallon1;
        }
        if (lvl2Endu == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SkinBallon2;
        }
        if (lvl3Endu == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SkinBallon3;
        }

        if (Input.GetKeyDown(KeyCode.Return) && inTrigger == true)
        {
            Debug.Log("Playing");
            PlayBall++;

            GetComponent<Rigidbody2D>().AddForce(my_PM.lastDirection * 50f);
            Debug.Log(my_PM.lastDirection);

            if (!soundPlayBall.isPlaying)
            {
                soundPlayBall.Play();
            }
            

            if (PlayBall == 3)
            {
                if (lvl1Endu == true)
                {
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu += 50f * Time.deltaTime;
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft += 50f * Time.deltaTime;
                    

                }
                else if (lvl2Endu == true)
                {
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu += 100f * Time.deltaTime;
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft += 100f * Time.deltaTime;
                    
                }
                else if (lvl3Endu == true)
                {
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().maxEndu += 150f * Time.deltaTime;
                    GameObject.FindGameObjectWithTag("Endurance").GetComponent<Endurance>().enduLeft += 150f * Time.deltaTime;

                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }
}
