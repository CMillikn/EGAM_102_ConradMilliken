using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallWin : MonoBehaviour
{
    public float ProgressTimer;
    void Update()
    {
        if (ProgressTimer > 2.5f)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Circle")
        {
            SceneManager.LoadScene(0);
        }
    }
}
