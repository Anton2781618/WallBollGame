using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    private ParallaxModel parallaxModel;

    void Start()
    {
        parallaxModel = FindObjectOfType<ParallaxModel>();

        foreach (var target in parallaxModel.objectsForParallax)
        {
            target.InitMaterial();
        }
    }
    
    public void Movement_Parallax(float speedParalax)
    {
        Vector2 offset = Vector2.zero;
        foreach (var target in parallaxModel.objectsForParallax)
        {
            offset = new Vector2(target.objectForParallax.position.x * speedParalax, 0f);    
            target.materialForParallax.mainTextureOffset = offset;
        }
    }

    public Transform Find_Paralax_Parent()
    {
        return parallaxModel.objectsForParallax[0].objectForParallax.parent;
    }
}
