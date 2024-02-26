using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    GameObject Dude;
    public Jumper JumperScript;
    public float actualScore;
    public TextMeshProUGUI ScoreText;
    void Start()
    {
        Dude = GameObject.Find("Dude");
        JumperScript = Dude.GetComponent<Jumper>();
        actualScore = JumperScript.actualScore;
    }

    
    void FixedUpdate()
    {
        actualScore = JumperScript.actualScore;
        ScoreText.text = actualScore.ToString();
    }
}
