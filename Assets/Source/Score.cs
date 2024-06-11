using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Button collectButton;
    private int score = 0;

    private void Start()
    {
        collectButton.onClick.AddListener(IncrementScore);
    }

    private void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
