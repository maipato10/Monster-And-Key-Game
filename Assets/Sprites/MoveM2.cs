using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveM2 : MonoBehaviour
{
    private float left;
    private float right;
    // Start is called before the first frame update
    void Start()
    {
        left = transform.position.x;
        right = transform.position.x + 17;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 3, right - left) + left, transform.position.y, transform.position.z);
    }
}
