using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginingScript : MonoBehaviour
{
    public static AudioClip beginingSound,silentSound;
    public static AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        beginingSound = Resources.Load<AudioClip>("start");
        silentSound = Resources.Load<AudioClip>("silent");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Sound(string sound)
    {
        switch (sound)
        {
            case "silent":
                audio.Pause();
                break;

            case "start":
                audio.Play();
                break;

            
        }
    }
}
