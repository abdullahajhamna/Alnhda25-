using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // Import SceneManager

public class ScoreManager2 : MonoBehaviour
{
    public static ScoreManager2 instance;
    public Text scoreText;
    private int score = 0;

    public int requiredCoins = 10;  // عدد العملات المطلوبة للانتقال للمشهد التالي
    public string nextSceneName;    // اسم المشهد التالي

    void Awake()
    {
        // Singleton pattern to ensure only one instance of ScoreManager exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score.ToString();

        // Check if player has collected the required number of coins
        if (score >= requiredCoins)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene(4);
    }
}
