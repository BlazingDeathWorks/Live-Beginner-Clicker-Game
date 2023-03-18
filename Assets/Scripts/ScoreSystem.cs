using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }
    public void IncreaseClickValueBy1(int cost)
    {
        IncreaseClickValue(1, cost);
    }
    public void IncreaseClickValueBy10(int cost)
    {
        IncreaseClickValue(10, cost);
    }
    public void IncreaseClickValueBy100(int cost)
    {
        IncreaseClickValue(100, cost);
    }

    public void IncreaseClickValue(int increaseValue, int costValue)
    {
        if (gameManager.score >= costValue)
        {
            gameManager.clickValue += increaseValue;
            gameManager.score -= costValue;
            gameManager.UpdateScoreText();
        }
    }
}
