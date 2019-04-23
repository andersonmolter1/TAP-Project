using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreObject : IComparable<ScoreObject>
{
    public string name;
    public int score;
    //public int rank; //Remember to create getRank() and setRank()

    public ScoreObject()
    {
        name = "NUL";
        score = 0;
    }

    public ScoreObject(string name, int score)
    {
        this.name = name;
        this.score = score;
    }

    public String getName()
    {
        return name;
    }

    public void setName()
    {
        this.name = name;
    }

    public int getScore()
    {
        return score;
    }

    public void setScore()
    {
        this.score = score;
    }

    public int CompareTo(ScoreObject other)
    {
        return score - other.getScore();
    }

    public string toString()
    {
        return name + ": " + score;
    }
}
