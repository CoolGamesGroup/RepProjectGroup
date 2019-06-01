using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    public void ReactToHit()
    {//метод, вызванный сценарием стрельбы
        AIEnemy behavior = GetComponent<AIEnemy>();
        if (behavior != null)
        {//проверяем, есть ли у объекта скрипт  AIEnemy 
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {//Изменяем цвет врага, ждем 1,5 секунды и уничтожаем его
        GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);//объект может уничтожить сам себя
    }
}
