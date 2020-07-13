using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour
{
    Button buttonl;
    [SerializeField]
    private int level;

    void Start()
    {
        buttonl = GetComponent<Button>();
        buttonl.onClick.AddListener(() => GoLevel());
    }

    void GoLevel()
    {
        PlayerPrefs.SetInt("level", level);
        StateManager.changeScene("Game");
    }
}
