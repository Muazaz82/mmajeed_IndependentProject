using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTimeLimit = 300f; // Set the game time limit in seconds
    private float timer;

    public Text gameOverText; // Reference to a UI Text component to display game over message

    void Start()
    {
        timer = gameTimeLimit;
        gameOverText.gameObject.SetActive(false); // Hide the game over text initially
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Implement game over logic here, such as displaying a game over screen
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0f; // Pause the game

        // You might want to reset the level or provide options for the player to restart, go to menu, etc.
        // Example: Reload the scene after a delay
        Invoke("ReloadScene", 3f);
    }

    void ReloadScene()
    {
        // Replace "YourSceneName" with the name of your scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Black_Hole");
    }
}
