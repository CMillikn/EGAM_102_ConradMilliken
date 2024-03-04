using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGameplay : MonoBehaviour
{
    public Button RestartButton;
    void Start()
    {
        RestartButton.onClick.AddListener(ButtonPressed);
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene(0);
    }
}
