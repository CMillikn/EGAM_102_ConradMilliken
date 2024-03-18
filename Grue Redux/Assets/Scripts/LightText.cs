using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightText : MonoBehaviour
{
    public LightSpread LightSpread;
    public TextMeshProUGUI lightText;
    public float LightNum;
    void Start()
    {
        lightText = GetComponent<TextMeshProUGUI>();
    }

    void FixedUpdate()
    {
        LightNum = Mathf.Round(LightSpread.LightMeter);
        lightText.text = LightNum.ToString();
    }
}
