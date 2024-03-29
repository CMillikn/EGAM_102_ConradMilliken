using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrueStalk : MonoBehaviour
{
    public Vector2 PlayerPos;
    public float Speed;
    public GameObject Player;
    public bool LightUp = false;
    public float playerDist;
    public AudioSource grueSound;
    public GameObject LoserDark;
    public SpriteRenderer LoserDarkSR;
    public GameObject JumpscareBlocker;
    public GameObject Music;
    void Start()
    {
        Player = GameObject.Find("Player");
        LoserDark = GameObject.Find("LoserDarkness");
        JumpscareBlocker = GameObject.Find("JumpscareBlocker");
        Music = GameObject.Find("Music");
        LoserDarkSR = LoserDark.GetComponent<SpriteRenderer>();
        grueSound = GetComponent<AudioSource>();
        StartCoroutine(EndGame());
    }
    public IEnumerator RunFromLight()
    {
        LightUp = true;
        yield return new WaitForSeconds(Random.Range(3f,8f));
        int rand = Random.Range(0, 3);
        if (rand == 0)
        {
            transform.position = new Vector2(11, 7);
        }
        if (rand == 1)
        {
            transform.position = new Vector2(-11, 7);
        }
        if (rand == 2)
        {
            transform.position = new Vector2(11, -7);
        }
        if (rand == 3)
        {
            transform.position = new Vector2(-11, -7);
        }
        LightUp = false;

    }
    public IEnumerator EndGame()
    {
        yield return new WaitForSeconds(100);
        Destroy(grueSound);
        transform.position = new Vector2(999999, 999999);
        Destroy(this);
    }

    public IEnumerator KillPlayer()
    {
        Destroy(Music);
        Destroy(grueSound);
        yield return new WaitForSeconds(Random.Range(5,10));
        Destroy(JumpscareBlocker);
    }

    void FixedUpdate()
    {
        if (LightUp == false)
        {
            PlayerPos = Player.transform.position;
            transform.position = Vector2.MoveTowards(transform.position, PlayerPos, Speed);
        }
        else if (LightUp == true) 
        {
            PlayerPos = Player.transform.position;
            transform.position = Vector2.MoveTowards(transform.position, PlayerPos, -Speed);
        }
        playerDist = Vector2.Distance(transform.position, PlayerPos);
        grueSound.volume = 1 - (playerDist * 0.1f);
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.name == "LightRange")
        {
            StartCoroutine(RunFromLight());
            Speed = Speed + 0.01f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            LoserDarkSR.enabled = true;
            transform.position = new Vector2(9999999999, 999999999999);
            StartCoroutine(KillPlayer());
        }
    }
}
