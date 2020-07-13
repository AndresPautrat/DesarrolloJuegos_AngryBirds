using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public BirdState birdState { set; get; }
    private TrailRenderer trailRenderer;
    Rigidbody2D rigidbody;
    CircleCollider2D collider2D;
    AudioSource source;

    private void Awake()
    {
        InitVariables();
    }

    void InitVariables()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<CircleCollider2D>();
        source = GetComponent<AudioSource>();
        trailRenderer.enabled = false;
        rigidbody.isKinematic = true;
        collider2D.radius = GameVariables.birdColliderRadiusBig;
        birdState = BirdState.BeforeThrown;
    }

    void OnThrow()
    {
        source.Play();
        trailRenderer.enabled = true;
        rigidbody.isKinematic = false;
        collider2D.radius = GameVariables.birdColliderRadiusNormal;
        birdState = BirdState.Thrown;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
