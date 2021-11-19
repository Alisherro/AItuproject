using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float startSeconds;
    public Text currentTime;

    void Start()
    {
        currentTime.text = currentTime.ToString();
    }
    void Update()
    {
        
        if (startSeconds <= 0)
        {
            Time.timeScale = 3;
            currentTime.text = "There is no time left";
            SceneManager.LoadScene(0);
        }
        else
        {
            startSeconds -= Time.deltaTime;
            currentTime.text = "Time left: " + Mathf.Round(startSeconds).ToString();
        }
    }


}
