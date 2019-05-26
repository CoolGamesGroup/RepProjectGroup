using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public float speed = 1.0f;//скорость движения
    public float damage = 1.0f;//переменная урона врага
    public float maxDistance = 10.0f;//дистанция для обнаружения игрока
    public float minDistance = 1.0f;

    public float distance;//переменная дистанции между врагом и игроком
    public Transform target;//координаты игрока

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);//находим дистанцию между игроком и врагом
        if (distance > maxDistance)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);//непрерывно движемся вперед в каждом кадре
        }
        if (distance < maxDistance && distance > minDistance)
        {

        }
    }
}
