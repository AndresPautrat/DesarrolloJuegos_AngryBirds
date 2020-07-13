using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [HideInInspector]
    Vector3 startPosition;
    float minCameraX = 0f, maxCameraX = 14f;
    [HideInInspector]
    bool isFollowing;
    [HideInInspector]
    public Transform birdToFollow;

    private void Awake()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            if (birdToFollow != null)
            {
                Vector3 birdPosition = birdToFollow.position;
                float x = Mathf.Clamp(birdPosition.x, minCameraX, maxCameraX);
                transform.position = new Vector3(x, startPosition.y, startPosition.z);
            }
            else
            {
                isFollowing = false;
            }
        }
    }
}
