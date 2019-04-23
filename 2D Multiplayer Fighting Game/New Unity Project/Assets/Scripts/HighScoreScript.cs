using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    //ScoreObjects have (string name, int score)
    ArrayList highScoreArray = new ArrayList();
    public List<ScoreObject> highScoreList = new List<ScoreObject>();
    public int rank;
    Text scoreString;
    string playerName;
    int score;

    void Start()
    {
        //PlayerPrefs.DeleteAll();//This is to restart the High Scores
        scoreString = GetComponent<Text>();
        List<ScoreObject> highScoreList = new List<ScoreObject>();
        if (!PlayerPrefs.HasKey("Rank1Name"))
        {
            for (int index = 0; index < 10; index++)
            {
                ScoreObject callScore = new ScoreObject();
                highScoreList.Add(callScore);
                SetScore(callScore.getName(), callScore.getScore());
            }
        }
        SetText();
    }

    void Update()
    {
        SetText();
    }

    public void NewHighScore()
    {
        score = PlayerPrefs.GetInt("GetScore");//"GetScore" comes from PointScript
        PlayerPrefs.SetString("LoopOnce", "true");
        score = PlayerPrefs.GetInt("GetScore");
        //playerName = PlayerPrefs.GetString("GetName");//DELETE THIS WHEN DONE
        int lowestScore = PlayerPrefs.GetInt("Rank10Score");
        print(PlayerPrefs.GetInt("Rank10Score"));
        if (score > lowestScore)
        {
            for (int index = 1; index <= 10; index++)
            {
                score = PlayerPrefs.GetInt("GetScore");
                int comparedScore = PlayerPrefs.GetInt("Rank" + index + "Score");
                PlayerPrefs.SetString("Rank" + index + "Name", "NUL");
                //string once = PlayerPrefs.GetString("LoopOnce");
                if (score > comparedScore && PlayerPrefs.GetString("LoopOnce").Equals("true"))//THIS ONE IS FOR INPUT TO GET THE SCORE
                {
                    //print("Type your name");//EDIT OUT???
                    PlayerPrefs.SetString("GetName", Input.inputString);//EDIT OUT???
                    PlayerPrefs.SetInt("TempScore", PlayerPrefs.GetInt("Rank" + index + "Score"));
                    PlayerPrefs.SetString("TempName", PlayerPrefs.GetString("Rank" + index + "Name"));
                    PlayerPrefs.SetInt("Rank" + index + "Score", PlayerPrefs.GetInt("GetScore"));
                    PlayerPrefs.SetString("Rank" + index + "Name", PlayerPrefs.GetString("GetName"));
                    PlayerPrefs.SetInt("GetScore", PlayerPrefs.GetInt("TempScore"));
                    PlayerPrefs.SetString("GetName", PlayerPrefs.GetString("TempName"));
                    PlayerPrefs.SetString("LoopOnce", "false");
                }
                else if (score > comparedScore)//THIS ONE ORGANIZES WITHOUT INPUT. Remember to get the Name in this one
                {//HIGH SCORE IS REMOVING THE SECOND HIGHSCORE
                    PlayerPrefs.SetInt("TempScore", PlayerPrefs.GetInt("Rank" + index + "Score"));
                    PlayerPrefs.SetString("TempName", PlayerPrefs.GetString("Rank" + index + "Name"));
                    PlayerPrefs.SetInt("Rank" + index + "Score", PlayerPrefs.GetInt("GetScore"));
                    PlayerPrefs.SetString("Rank" + index + "Name", PlayerPrefs.GetString("GetName"));
                    PlayerPrefs.SetInt("GetScore", PlayerPrefs.GetInt("TempScore"));
                    PlayerPrefs.SetString("GetName", PlayerPrefs.GetString("TempName"));
                }
            }
        }
        SetText();
    }
    public void SetScore(string playerName, int score)
    {
        PlayerPrefs.SetString("Rank" + rank + "Name", playerName);
        PlayerPrefs.SetInt("Rank" + rank + "Score", score);
    }

    public void SetText()
    {
        playerName = PlayerPrefs.GetString("Rank" + rank + "Name");
        score = PlayerPrefs.GetInt("Rank" + rank + "Score");
        //scoreString.text = "Rank" + rank + ": Score: " + score + " " + playerName;
        scoreString.text = "Rank" + rank + ": Score: " + score + " ";
    }
}