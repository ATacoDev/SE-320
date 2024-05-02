using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlayLoop : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public TextMeshProUGUI target;
    public TextMeshProUGUI result;
    public PlayerMovement playerMovement;
    public FallingFruit fallingFruit;
    public Timer timer;
    public Canvas preGameCanvas;
    public Canvas endGameCanvas;
    private int randomRangeLow;
    private int randomRangeHigh;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        randomRangeLow = Random.Range(20, 36);
        randomRangeHigh = randomRangeLow + 5;
        target.text = "" + randomRangeLow + " and " + randomRangeHigh;
        score = 0;

        endGameCanvas.enabled = false;

        foreach (Transform child in endGameCanvas.transform) {
            child.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        playerMovement.ToggleMovement();
        fallingFruit.BeginSpawning();
        preGameCanvas.enabled = false;

        foreach (Transform child in preGameCanvas.transform) {
            child.gameObject.SetActive(false);
        }

        timer.StartTimer();

        
    }

    public void stopGame()
    {
        playerMovement.ToggleMovement();
        endGameCanvas.enabled = true;

        foreach (Transform child in endGameCanvas.transform) {
            child.gameObject.SetActive(true);
        }

        if ((score > randomRangeLow) && (score < randomRangeHigh)){
            WinGame();
        }else{
            LoseGame();
        }
    }

    public void incrementScore(int amount){
        print("score increased");
        score += amount; 
        textMeshPro.text = "" + score;
    }

    private void WinGame(){
        result.text = "You Win! :D";
    }
    private void LoseGame(){
        result.text = "You Lose :(";
    }
}
