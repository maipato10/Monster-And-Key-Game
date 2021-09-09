using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyMover : MonoBehaviour
{
    public float degreesPerSec = 360f;
    float time = 10.0f;
    public Text keyUpdate;
    void Start()
    {
        
    }

    void Update()
    {
        float rotAmount = degreesPerSec * Time.deltaTime / time;
        float curRot = transform.localRotation.eulerAngles.z;
        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "hero")
        {
            SoundManagerScript.PlaySound("key");
            Destroy(gameObject);
            keyUpdate.text = "Key Found: Yes";
            
        }
        
    }
}
