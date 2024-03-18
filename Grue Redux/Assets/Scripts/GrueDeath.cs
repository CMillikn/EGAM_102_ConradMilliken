using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrueDeath : MonoBehaviour
{
    GameObject JumpscareCatcher;
    AudioSource GrueScare;
    public float Proximity;
    void Start()
    {
        JumpscareCatcher = GameObject.Find("JumpscareCatcher");
        GrueScare = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Proximity = Vector2.Distance(JumpscareCatcher.transform.position, transform.position);
        GrueScare.volume = 1 - (Proximity * 0.04f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "JumpscareCatcher")
        {
            SceneManager.LoadScene(2);
        }    
    }
}
