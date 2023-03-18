using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Timer Variables
    public Text timeText;
    [SerializeField] private float maxTime;
    private float time;

    //Click Value Variables
    public Text valueText;
    public int clickValue;

    //Score Variables
    public Text scoreText;
    public int score;

    void Awake()
    {
        time = maxTime;
    }

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        time -= Time.deltaTime;

        if (time <= 0f)
        {
            time = maxTime;
            score = 0;
            UpdateScoreText();
        }

        float intTime = Mathf.Ceil(time);
        timeText.text = "Time: " + intTime.ToString();
    }

    public void Score()
    {
        score += clickValue;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void UpdateValueText()
    {
        valueText.text = "+" + clickValue;
    }
}