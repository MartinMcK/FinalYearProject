using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    [SerializeField]
    private int score = 0;
    public TextMeshProUGUI scoreText;


    void Update()
    {
        SetScoreToTMP();

    }

    public void AddScore(int value)
    {
        score += value; //adds to the score 
    }

    public void SetScoreToTMP()
    {
        scoreText.text = score.ToString();
    }
}
