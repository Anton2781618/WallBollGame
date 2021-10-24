using System.Collections.Generic;
using UnityEngine;

public class WallModel : MonoBehaviour
{
    public Transform prefabWall;
    private Queue<Transform> wals = new Queue<Transform>();

    private void Start()
    {
        Create_Wall();
    }

    private void Create_Wall()
    {
        if(wals.Count > 0)return;

        for (int i = 0; i < 10; i++)
        {
            var bufferWall = Instantiate(prefabWall, Vector3.zero, Quaternion.identity);
            wals.Enqueue(bufferWall);
        }
    }

    public void Reposition_Wals()
    {
        foreach (var wal in wals)
        {
            wal.position = Vector3.zero;
        }
    }

    public void Change_Wall_Position()
    {
        Vector3 camPos = Camera.main.transform.position;
        Vector3 posWal = new Vector3(camPos.x + 20, camPos.y + Random.Range(-3, 3), 1);

        var bufferWall = wals.Dequeue();
        bufferWall.position = posWal;
        wals.Enqueue(bufferWall);
    } 
}
