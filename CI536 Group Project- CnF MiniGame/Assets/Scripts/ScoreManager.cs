using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public YouWinScreen YouWinScreen;
    public static ScoreManager instance;
    public Text scoreText;
    int score = 0;

    private void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        GameObject[] OAR = GameObject.FindGameObjectsWithTag("Impurities");
        if (OAR.Length == 0)
        {
            YouWinScreen.Setup(score);
        }
    }

    public void AddPoint()
    {
        score += 10;
        scoreText.text = "Score: " + score.ToString();
    }
}