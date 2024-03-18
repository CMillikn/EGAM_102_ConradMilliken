using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternOil : MonoBehaviour
{
    public GameObject Player;
    public LightSpread LightSpread;
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(Random.Range(-8,8), Random.Range(4,-4));
        if (collision.gameObject.name == "Player")
        {
            LightSpread.LightMeter = LightSpread.LightMeter + 10;
        }
    }
}
