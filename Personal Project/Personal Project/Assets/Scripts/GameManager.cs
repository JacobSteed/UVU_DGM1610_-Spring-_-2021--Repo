using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public bool isGameActive;
    
    public TextMeshProUGUI gameOverText;
    public Button resetButton;
    public GameObject titleScreen;

    //Sets the activity of 
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        resetButton.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
