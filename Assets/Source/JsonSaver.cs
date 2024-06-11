using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonSaver : ISaver
{
    public void SaveScore(int score, string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = Application.persistentDataPath + "/score.json";

        File.WriteAllText(path, JsonUtility.ToJson(new ScoreData(score)));
    }

    [System.Serializable]
    private class ScoreData
    {
        public int score;

        public ScoreData(int score)
        {
            this.score = score;
        }
    }
}
