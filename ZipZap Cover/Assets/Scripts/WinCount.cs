using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCount : MonoBehaviour
{
    public float ProgressTimer;
    void Awake()
    {

    }

    
    void Update()
    {
        if (ProgressTimer > 2.5f)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "SquareLeft")
        {
            SceneManager.LoadScene(0);
        }
        else if (collision.gameObject.name == "SquareRight")
        {
            SceneManager.LoadScene(0);
        }
        else if (collision == null)
        {

        }
    }
}
