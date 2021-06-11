using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text timerText;
    float gameTime = 60.0f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("f1");
        }
        else
        {
            timerText.text = "GameOver";
        }
    }
}
