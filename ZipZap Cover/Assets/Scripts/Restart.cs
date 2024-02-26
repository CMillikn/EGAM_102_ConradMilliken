using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Button RestartButton;
    void Start()
    {
        RestartButton.onClick.AddListener(ButtonPressed);
    }

    // Update is called once per frame
    public void ButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
