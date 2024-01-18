using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    public float survivalTime = 30f;
    private float elapsedTime = 0f;

    public Text countdownText;
    public float countdownTime = 10f;

    void Start()
    {
        // Set the initial countdown time
        countdownTime = survivalTime;
        UpdateCountdownText();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= survivalTime)
        {
            LoadGameClearScene();
        }
        else
        {
            UpdateCountdownTimer();
        }
    }

    void UpdateCountdownTimer()
    {
        if (countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            UpdateCountdownText();
        }
        else
        {
            // Handle what should happen when the countdown reaches zero (e.g., end the game)
            Debug.Log("Game Over!");
        }
    }

    void UpdateCountdownText()
    {
        int seconds = Mathf.FloorToInt(countdownTime);
        int milliseconds = Mathf.FloorToInt((countdownTime - seconds) * 100); // Small modification here
        countdownText.text = "Ë¶êŒÇ‹Ç≈Ç†Ç∆: " + seconds.ToString("D2") + "." + milliseconds.ToString("D2") + "ïb";
    }

    void LoadGameClearScene()
    {
        SceneManager.LoadScene("ending1"); // Replace "GameClearSceneName" with the actual name of your game clear scene
    }
}
