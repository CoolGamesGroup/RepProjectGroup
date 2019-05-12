using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 5.0f;
    public float range = 50.0f;

    public Camera cam;

    public ParticleSystem plazmLaser;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; //скрываем указатель мыши
        plazmLaser.Stop();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            plazmLaser.Play();
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(point); //Создание луча методом ScreenPointToRay().
            if (Physics.Raycast(ray, out hit ,range))
            {
                Debug.Log(hit.transform.name);

                Strength objectVase = hit.transform.GetComponent<Strength>();
                if (objectVase != null)
                {
                    objectVase.Damage(damage);
                }
            }
        }
    }

    void OnGUI()
    {
        float posX = cam.pixelWidth / 2;
        float posY = cam.pixelHeight / 2;
        GUI.Label(new Rect(posX, posY, 12, 12), "*");//команда GUI.Label() отображает символ *
    }
}
