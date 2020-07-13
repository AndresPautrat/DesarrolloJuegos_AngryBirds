using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScroll : MonoBehaviour
{
    float parallaxFactor;
    Vector3 previusCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        previusCameraPosition=Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta=Camera.main.transform.position-previusCameraPosition;
        delta.y=0f;
        delta.x=0f;
        transform.position+=delta/parallaxFactor;
        previusCameraPosition=Camera.main.transform.position;
    }
}
