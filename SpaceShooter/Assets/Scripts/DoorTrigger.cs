using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject[] targets;//список целевых объектов, на которых будет реагировать триггер

    void OnTriggerEnter(Collider other)
    {//метод OnTriggerEnter() вызывается при попадании объекта в зону
        if (other.tag == "Player")
        {
            foreach (GameObject target in targets)
            {
                target.SendMessage("Open");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {//метод OnTriggerExit() вызывается при выходе из зоны
        if (other.tag == "Player")
        {
            foreach (GameObject target in targets)
            {
                target.SendMessage("Close");
            }
        }
    }
}
