using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator doorAnim;

    void Start()
    {//подключаемся к компоненту Animator объекта door_1
        doorAnim = gameObject.GetComponent<Animator>();
    }


    public void Open()
    {//меняем параметр ParOpen на true
        doorAnim.SetBool("ParOpen", true);
    }

    public void Close()
    {//меняем параметр ParOpen на false
        doorAnim.SetBool("ParOpen", false);
    }
}
