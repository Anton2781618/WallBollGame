using UnityEngine;

public class StartingSettingsModel : MonoBehaviour
{
    public int SpeedCamera { get; set; } = 5;
    public int SpeedParalax {get; set;} = 1;
    public int Attempt {get; set;} = 0;
    public int VerticalSpeed {get; set;} = 1;


    public void VerticalSpeedUp()
    {
        VerticalSpeed++;
    }
}
