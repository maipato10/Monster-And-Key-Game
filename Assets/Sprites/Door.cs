using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Text decider;
    public Text keyTxt;
    public Rigidbody2D rbMonster;
    public Button restart, quit;

    // Start is called before the first frame update
    void Start()
    {
        rbMonster = GetComponent<Rigidbody2D>();
        decider.gameObject.GetComponent<Text>();
        keyTxt.gameObject.GetComponent<Text>();
        restart.gameObject.GetComponent<Button>();
        quit.gameObject.GetComponent<Button>();
        decider.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag == "hero" && keyTxt.text.Equals( "Key Found: Yes"))
        {
            BeginingScript.Sound("silent");
            decider.gameObject.SetActive(true);
            rbMonster.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Time.timeScale = 0f;
            SoundManagerScript.PlaySound("finish");
            restart.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
        }

    }

}
