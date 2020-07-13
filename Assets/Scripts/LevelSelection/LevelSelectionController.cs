using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionController : MonoBehaviour
{
    [SerializeField]
    Button backBtn;

    void Start()
    {
        backBtn.onClick.AddListener(() => StartGame());
    }

    void StartGame()
    {
        StateManager.changeScene("Game");
    }
}
