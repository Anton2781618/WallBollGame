using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//находится на 
public class CameraController : MonoBehaviour
{    

    ///<summary>
    /// метод описывает движение камеры.У камеры есть дочерние объекты
    ///<summary>
    public void Movemant_Camera(int speedCamera)
    {
        Camera.main.transform.Translate(speedCamera * Time.deltaTime,0,0);
    }
}
