using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Timer Variables
    private float time;
    [SerializeField] private float maxTime;
    public Text timeText;

    //Click Value Variables
    public int clickValue;

    //Score Variables
    public int score;
    public Text scoreText;

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
        }

        float roundTime = Mathf.Round(time * 10f) / 10f;

        timeText.text = "Time: " + roundTime.ToString();
    }

    public void Score()
    {
        score += clickValue;
        scoreText.text = "Score: " + score.ToString();
    }
}