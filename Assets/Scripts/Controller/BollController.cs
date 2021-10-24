using UnityEngine;

public class BollController : MonoBehaviour
{
    public Transform PathToParentBall{get; set;}
    private Transform ball;

    public void InstantiateBall(Transform ballPrefab)
    {
        ball = Instantiate(ballPrefab, PathToParentBall.position, Quaternion.identity);
        ball.SetParent(PathToParentBall);

        //ставим шарик в начальную удобную позицию
        ball.position = new Vector3(ball.position.x - 3, ball.position.y + 2, 1);
    }

    public void DestroyBall()
    {
        Destroy(ball.gameObject);
    }

    ///<summary>
    /// метод управления шалом
    ///<summary>
    public void Movement_Ball(int VerticalSpeed)
    {
        if(!ball)return;

        Vector3 BollPos = ball.position; 

        if(Input.GetAxis("Vertical") != 0)
        {
            ball.position = new Vector2(BollPos.x, BollPos.y + VerticalSpeed * Time.deltaTime);
        }
        else
        {
            ball.position = new Vector2(BollPos.x, BollPos.y - VerticalSpeed * Time.deltaTime);            
        }
    }    
}
