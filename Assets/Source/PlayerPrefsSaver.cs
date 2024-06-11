using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaver : ISaver
{
    public void SaveScore(int score, string path = null)
    {
        PlayerPrefs.SetInt("score", score);
    }
}
