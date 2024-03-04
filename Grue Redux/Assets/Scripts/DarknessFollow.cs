using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessFollow : MonoBehaviour
{
    public GameObject Player;
    public float intensity;
    public float increase;
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        this.transform.position = Player.transform.position; 
        if (Input.GetKey(KeyCode.Space))
        {
            if (intensity < 6)
            {
                intensity = intensity + increase;
            }
        }
        else
        {
            if (intensity > 3f)
            {
                intensity = intensity - increase;
            }
        }
        this.transform.localScale = new Vector2(intensity, intensity);
        if (intensity < 3)
        {
            intensity = 3f;
        }
    }
}
