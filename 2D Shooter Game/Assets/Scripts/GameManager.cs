﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Shooter Level 1");
    }

    
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }


    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
