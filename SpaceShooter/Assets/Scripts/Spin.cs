using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed == 6.0f)
        {
            transform.Rotate(0, speed, 0);
        }
        else
        {
            transform.Rotate(0, -speed, 0);
        }

    }
}
