using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private static TextMeshProUGUI scoreText;
    private static int score = 0;

    private void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public static void GainScore()
    {
        score++;

        scoreText.SetText(score.ToString());
    }
}
