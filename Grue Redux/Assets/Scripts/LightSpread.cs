using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpread : MonoBehaviour
{
    public Rigidbody2D rbLight;
    public float intensity;
    public float increase;
    void Start()
    {
        rbLight = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (intensity < 3)
            {
                intensity = intensity + increase;
            }
        }
        else
        {
            if (intensity > 0.5f)
            {
                intensity = intensity - increase;
            }
        }
        this.transform.localScale = new Vector2(intensity, intensity);
        if (intensity < 0.5f)
        {
            intensity = 0.5f;
        }
    }
}
