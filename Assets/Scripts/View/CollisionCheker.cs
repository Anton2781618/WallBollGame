using UnityEngine;
public delegate void Message();

//находится на шаре 
public class CollisionCheker : MonoBehaviour
{
    
    public static event Message CollisionEvent; 
    void OnCollisionEnter2D()
    {
        CollisionEvent?.Invoke(); 
    }
}
