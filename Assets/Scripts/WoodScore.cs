﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodScore : MonoBehaviour
{

    public TMP_Text scoreText;
    int currentScore = 0;

    void Update()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
    }
}
