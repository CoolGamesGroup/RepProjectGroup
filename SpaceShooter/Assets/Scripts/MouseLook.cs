using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivityHor = 9.0f; // переменная для скорости вращения
    public float sensitivityVert = 9.0f; // переменная для скорости по вертикали
    public float minimumVert = -45.0f; //минимальный угол по вертикали
    public float maximumVert = 45.0f; // максимальный угол по вертикали
    private float _rotationX = 0; //закрытая переменная для сохраннеия угла поворота вертикали

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
        _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
        float delta = Input.GetAxis("Mouse X") * sensitivityHor; //Новая переменная хранит считываемое изменение мыши по Х

    }
}
