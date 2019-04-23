using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject player;
    public int points = 0;
    public int goldCount = 0;
    public int iceCreamCount = 0;
    public int totalPoints = 0;
    public int highScore;
    public int maxY = -2;
    public int minY;
    Text score;
    public bool isScore;
    public bool isHighScore;
    string gameOver;
    bool once;

    void Start()
    {
        once = true;
        PlayerPrefs.SetInt("IceCream", 0);
        PlayerPrefs.SetInt("Gold", 0);
        PlayerPrefs.SetString("PlayerDestroyed", "false");
        score = GetComponent<Text>();
        PlayerPrefs.DeleteKey("GetScore");
        PlayerPrefs.SetString("GameOver", "false");
        PlayerPrefs.SetInt("MinY", -5);
        iceCreamCount = 0;
        if (isScore)
        {
            points = 0;
            iceCreamCount = 0;
            goldCount = 0;
            score.text = "Score: " + points;
        }
        if (isHighScore)
        {
            if (PlayerPrefs.HasKey("Rank1Name"))
            {
                points = PlayerPrefs.GetInt("Rank1Score");
            }
            score.text = "High Score: " + points;
            points = 0;
        }
    }

    void Update()
    {
        IceCreamScript ics = new IceCreamScript();
        HighScoreScript hss = new HighScoreScript();
        minY = maxY - 3;
        print(PlayerPrefs.GetInt("Gold"));
        gameOver = PlayerPrefs.GetString("GameOver");
        iceCreamCount = PlayerPrefs.GetInt("IceCream");
        goldCount = PlayerPrefs.GetInt("Gold");
        int iceCreamPoints = iceCreamCount * 350 + goldCount * 3000;
        totalPoints = points + iceCreamPoints;
        if (isScore)
        {
            score.text = "Score: " + totalPoints;
        }
        if(isHighScore)
        {
            if(totalPoints > PlayerPrefs.GetInt("Rank1Score"))
            {
                score.text = "High Score: " + totalPoints;
            }
        }
        if ((int)playerPosition.position.y > maxY)
        {
            PlayerPrefs.SetInt("MinY", minY);
            if (isScore)
            {
                //print(PlayerPrefs.GetInt("IceCream"));
                //print(PlayerPrefs.GetInt("Gold"));
                maxY = (int)playerPosition.position.y;
                points += 1;
                totalPoints = points + iceCreamPoints;
                score.text = "Score: " + totalPoints;
            }
            if (isHighScore)
            {
                maxY = (int)playerPosition.position.y;
                points += 1;
                totalPoints = points + iceCreamPoints;
                if (points > PlayerPrefs.GetInt("Rank1Score"))
                {
                    highScore = points;
                    score.text = "High Score: " + totalPoints;
                }
                else if (PlayerPrefs.GetInt("Rank1Score") > points)
                {
                    score.text = "High Score: " + PlayerPrefs.GetInt("Rank1Score");
                }
            }
        }
        
        if ((int)playerPosition.position.y <= minY && gameOver.Equals("false") && once)
        {
            PlayerPrefs.SetString("GameOver", "true");
            PlayerPrefs.SetInt("GetScore", totalPoints);
            once = false;
            hss.NewHighScore();
            if (isHighScore)
            {
                points = 0;
            }
        }
        string destroyed = PlayerPrefs.GetString("PlayerDestroyed");
    }
}