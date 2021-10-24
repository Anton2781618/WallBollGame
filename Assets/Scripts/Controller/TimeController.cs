using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
   private float timeInSeconds; 
   private float Culdown = 15f; 
   public event Message SpeedUpEvent; 

   public string Timer()
   {
        timeInSeconds += Time.deltaTime;

        return ("" + (int)(timeInSeconds / 60)+ ":" + (int)(timeInSeconds % 60)); 
   }

   public void Culdown_For_Vertical_Speed()
   {
       Culdown -= 1 * Time.deltaTime;
       if(Culdown <= 0)
       {
           SpeedUpEvent?.Invoke();
           Culdown = 15f;
       }

   }

   public void Reset_Time()
   {
       timeInSeconds = 0;
   }
}
