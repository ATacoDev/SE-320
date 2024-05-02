using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float timeRemaining;
    public bool timerIsRunning = false;
    public GamePlayLoop gamePlayLoop;
    public FallingFruit fallingFruit;

    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 1)
            {
                timeRemaining -= Time.deltaTime;
                timeText.text = "" + (int)timeRemaining;
                if (timeRemaining < 2)
                {
                    fallingFruit.StopSpawning();
                }
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                gamePlayLoop.stopGame();
            }
        }
    }

    public void StartTimer()
    {
        timerIsRunning = true;
    }
}

