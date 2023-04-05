using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextScore : MonoBehaviour
{
    TextMeshProUGUI text;
    int score = 0;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void ScoreUp(int value)
    {
        score += value;
        text.text = "Score : " + score;
    }
}
