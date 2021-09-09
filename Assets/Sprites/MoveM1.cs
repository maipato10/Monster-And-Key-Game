using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveM1 : MonoBehaviour
{
    public float _speed = 1.5f;
    public int direction = 1;
    public double top = 8.26;
    public double down = -8.26;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= down)
            direction = 1;

        transform.Translate(0, direction * Time.fixedDeltaTime * 2, 0);
    }
    
}
