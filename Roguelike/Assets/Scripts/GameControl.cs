﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameoverText;
    public bool gameOver = false;
    public float ScrollSpeed = -1.5f;
    private int score = 0;
    public Text scoreText;
    private void Awake()
    {
       if(instance == null)
        {
            instance = this;
        }

       else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        if(gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
            
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameoverText.SetActive(true); 
        gameOver = true;
    }
}

