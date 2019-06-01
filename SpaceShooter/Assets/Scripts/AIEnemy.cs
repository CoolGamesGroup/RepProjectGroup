using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public float speed = 1.0f;//скорость движения
    public int damage = 1;//переменная урона врага
    public float maxDistance = 10.0f;//дистанция для обнаружения игрока
    public float minDistance = 1.0f;

    public float distance;//переменная дистанции между врагом и игроком
    public Transform target;//координаты игрока

    public PlayerCharacter player;

    private bool _alive;//логическая переменная для слежения за жизнью

    void Start()
    {
        _alive = true; //делаем ее в начале истинной
    }

    void Update()
    {
        if (_alive)
        { 
            distance = Vector3.Distance(transform.position, target.position);//находим дистанцию между игроком и врагом
            if (distance > maxDistance)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);//непрерывно движемся вперед в каждом кадре
            }
            if (distance < maxDistance && distance > minDistance)
            {
                transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.LookRotation(target.position - transform.position), speed * Time.deltaTime);
                transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
            }
            if (distance < minDistance)
            {
                player.Hurt(damage);
            }
        }
    }

    public void SetAlive(bool alive)
    {//открывает метод,который из вне позволяет воздействовать на переменную
        _alive = alive;
    }
}
