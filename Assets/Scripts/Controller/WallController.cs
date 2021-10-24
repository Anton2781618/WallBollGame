using UnityEngine;

public class WallController : MonoBehaviour
{
    private WallModel wallModel;
    private float culdown = 0f;

    private void Start()
    {
        wallModel = FindObjectOfType<WallModel>();
    }

    public void Reposition_Wals()
    {
        wallModel.Reposition_Wals();
    }

    public void Culdown_For_Change_Position()
    {
        culdown -= Time.deltaTime;

        if(culdown <= 0)
        {
            Change_Position();
            culdown = Random.Range(0.5f, 0.9f);
        }
    }
    
    private void Change_Position()
    {
       wallModel.Change_Wall_Position();
    }
}
