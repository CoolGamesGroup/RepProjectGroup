using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 0.25f; // переменная скорости

    void Start()
    {

    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed; //    Horizontal - дополнительное имя для сопоставления с клавиатурой
        float deltaZ = Input.GetAxis("Vertical") * speed;
        transform.Translate(deltaX, 0, deltaZ);
    }

}
