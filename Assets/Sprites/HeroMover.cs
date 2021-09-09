using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeroMover : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Text txt ;
    public float sec = 14f;
    
   
    void Start()
    {
        
        txt.gameObject.GetComponent<Text>();
        rb = GetComponent<Rigidbody2D>();
        txt.gameObject.SetActive(false);
        

    }

    void Update()
    {
        
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }
    //Reliable when working with Physics its calles 50 times pers second
    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        
        if(col.gameObject.tag == "Monster")
        {
            rb.isKinematic = true;
            txt.gameObject.SetActive(true);
            Pausing();
           

        }
       

    }
    public void Pausing()
    {
        sec = 0f;
        speed = 0f;
        BeginingScript.Sound("silent");
        SoundManagerScript.PlaySound("dead");
        StartCoroutine(PausingGame());
        





    }
    public IEnumerator PausingGame()
    {
        
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
        BeginingScript.Sound("start");

    }
    
    
}
