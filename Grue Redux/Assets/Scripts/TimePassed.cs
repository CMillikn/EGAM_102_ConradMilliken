using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimePassed : MonoBehaviour
{
    public TextMeshProUGUI TimeRemaining;
    public float TimeTilSun = 100;

    void FixedUpdate()
    {
        if (TimeTilSun > 0)
        {
            TimeTilSun = TimeTilSun - Time.fixedDeltaTime;
            TimeRemaining.text = Mathf.Round(TimeTilSun).ToString();
        }
    }
}
