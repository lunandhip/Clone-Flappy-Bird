﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Для работы с канвасиком

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
    }

   
    void Update()
    {
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            score++;
        }
    }
}