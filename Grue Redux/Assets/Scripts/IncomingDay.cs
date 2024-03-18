using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncomingDay : MonoBehaviour
{
    public SpriteRenderer Opacity;
    float Reduction = 0;
    void Start()
    {
        Opacity = GetComponent<SpriteRenderer>();
        StartCoroutine(BeginCountdown());
    }

    public IEnumerator BeginCountdown()
    {
        yield return new WaitForSeconds(60);
        StartCoroutine(IncreaseSky());
    }

    public IEnumerator IncreaseSky()
    {
        while (Reduction < 40)
        {
            yield return new WaitForSeconds(0.1f);
            Reduction = Reduction + 0.1f;
            Opacity.color = new Color(1, 1, 1, Reduction * 0.01f);
        }
    }

    public IEnumerator EndGame()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }

    private void FixedUpdate()
    {
        if ((Reduction >= 40) && (Reduction < 100))
        {
            Reduction = Reduction + 1f;
            Opacity.color = new Color(1, 1, 1, Reduction * 0.01f);
        }
        if (Reduction >= 100)
        {
            StartCoroutine(EndGame());
        }
    }
    
}
