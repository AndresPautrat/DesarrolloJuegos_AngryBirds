using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int currentBirdIndex;
    [HideInInspector]
    public GameState gameState;
    List<GameObject> bricks;
    List<GameObject> birds;
    List<GameObject> pigs;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Start;
        bricks = new List<GameObject>(GameObject.FindGameObjectsWithTag("Brick"));
        birds = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bird"));
        pigs = new List<GameObject>(GameObject.FindGameObjectsWithTag("Pig"));
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.Start:
                if (Input.GetMouseButtonUp(0))
                {
                    Anima
                }
                break;
            case GameState.Playing:
                break;
            case GameState.Won:
                break;
            case GameState.Lost:
                break;
        }
    }

    void AnimateBirdToSlingShot()
    {
        gameState = GameState.BirdMovingToSlingerShot;
        //birds[currentBirdIndex].transform.positionTo;
    }

    bool BrickBirdPigsStoppedMoving()
    {
        foreach (GameObject item in bricks.)
        {

        }
        return true;
    }
}
