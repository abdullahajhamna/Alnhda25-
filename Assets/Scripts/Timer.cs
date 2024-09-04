using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingaTime;
    // Update is called once per frame
    void Update()
    {
        if (remainingaTime < 0)
        {
            remainingaTime = 0;
            timerText.color = Color.red;
            SceneManager.LoadSceneAsync(2);
        }
        remainingaTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingaTime / 60);
        int seconds = Mathf.FloorToInt(remainingaTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    
    }
}
