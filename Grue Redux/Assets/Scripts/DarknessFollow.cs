using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessFollow : MonoBehaviour
{
    public GameObject Player;
    public float intensity;
    public float increase;
    public LightSpread LightSpread;
    public LanternGrounded LanternGrounded;
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        this.transform.position = Player.transform.position; 
        if (LightSpread.LightMeter > 0)
        {
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    if (intensity < 8)
                    { 
                        if (LanternGrounded.IsGrounded == false)
                        {
                            intensity = intensity + increase;
                        }
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
                    if (LanternGrounded == false)
                        {
                            intensity = 3f;
                        }
                }
            }
            if (LanternGrounded.IsGrounded == true)
            {
                if (intensity > 1)
                {
                    intensity = 1;
                    this.transform.localScale = new Vector2(intensity, intensity);
                }
            }
        }
        else
        {
            if (intensity > 1f)
            {
                intensity = 1f;
                this.transform.localScale = new Vector2(intensity, intensity);
            }
        }
    }
}
