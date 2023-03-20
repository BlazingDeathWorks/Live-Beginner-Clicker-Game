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
    private const string CLICK_VALUE = "Click Value";

    //Score Variables
    public Text scoreText;
    public int score;

    void Awake()
    {
        time = maxTime;

        int savedClickValue = PlayerPrefs.GetInt(CLICK_VALUE);

        if (savedClickValue <= clickValue) return;

        clickValue = savedClickValue;
        UpdateValueText();
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

    //Tooling (Editor Only)
    [ContextMenu("ResetClickValue")]
    private void ResetClickValue()
    {
        PlayerPrefs.SetInt(CLICK_VALUE, 1);
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

    public void SaveClickValue()
    {
        PlayerPrefs.SetInt(CLICK_VALUE, clickValue);
    }
}