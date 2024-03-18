using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpread : MonoBehaviour
{
    public Rigidbody2D rbLight;
    public float intensity;
    public float increase;
    public bool lanternHave = true;
    public PhantomFollow PhantomFollow;
    public LanternGrounded LanternGrounded;
    public float LightMeter = 100;
    void Start()
    {
        rbLight = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Checks if the player has their lantern, if so then the code is executed
        //Expands the light hitbox if the player presses space
            if (Input.GetKey(KeyCode.Space))
            {
                if (LightMeter > 0)
                {
                    LightMeter = LightMeter - 0.2f;
                }
                if (intensity < 3)
                {
                    if (LanternGrounded.IsGrounded == false)
                    {
                        if (LightMeter > 0)
                        {
                            intensity = intensity + increase;
                        }
                    }
                    if (LanternGrounded.IsGrounded == true)
                    {

                    }
                }
            }
            //Shrinks the light hitbox when the player puts down the lantern
            else
            {
                if (LightMeter > 0)
                {
                    LightMeter = LightMeter - 0.001f;
                }
                if (intensity > 0.5f)
                {
                    intensity = intensity - increase;
                }
            }
            //Keeps the light from getting too small
            this.transform.localScale = new Vector2(intensity, intensity);
            if (intensity < 0.5f)
            {
                intensity = 0.5f;
            }
        //If the light meter goes above 100, no it doesn't
        if (LightMeter > 100)
        {
            LightMeter = 100;
        }
        //If the player doesn't have their lantern, this code does nothing
        
    }
}
