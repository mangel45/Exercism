using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return scores[scores.Count - 1];
    }

    public int PersonalBest()
    {
        return scores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return scores.OrderByDescending(s => s).Take(3).ToList();
    }
}