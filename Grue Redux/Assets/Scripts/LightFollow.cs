using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{
    public GameObject Player;
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        this.transform.position = Player.transform.position;
    }
}
