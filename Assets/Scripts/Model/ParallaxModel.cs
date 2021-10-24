using System.Collections.Generic;
using UnityEngine;
using System;

public class ParallaxModel : MonoBehaviour
{    
    public List<ObjectsForParallaxSpecification> objectsForParallax;
    
    [Serializable]
    public class ObjectsForParallaxSpecification
    {
        public Transform objectForParallax;
        public Material materialForParallax;

        public void InitMaterial()
        {
            materialForParallax = objectForParallax.GetComponent<SpriteRenderer>().material;
        }
    }
}
