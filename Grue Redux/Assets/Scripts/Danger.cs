using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    public GameObject Player;
    public GameObject Grue;
    public SpriteRenderer DangerColor;
    public float Proximity;
    void Start()
    {
        Player = GameObject.Find("Player");
        Grue = GameObject.Find("Grue");
    }

    void FixedUpdate()
    {
        Proximity = 1 - (Vector2.Distance(Player.transform.position, Grue.transform.position) * 0.2f);
        DangerColor.color = new Color(1,1,1,Proximity);
        transform.localScale = new Vector2(Random.Range(1.1f, 1.4f), Random.Range(1.1f, 1.4f));
    }
}
