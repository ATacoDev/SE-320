using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordChecker : MonoBehaviour
{
    
    [SerializeField] private CharacterAssigner characterAssigner;
    public MoveWorld moveWorldPlayer;
    public MoveWorld moveWorldCamera;
    public CanvasManager canvasManager;
    public GameObject bridge1;
    
    public void OnClick()
    {
        characterAssigner.setGuessedWord();
        if (characterAssigner.getGuessedWord() == characterAssigner.correctWord)
        {
            moveWorldPlayer.StartMovement();
            moveWorldCamera.StartMovement();
            characterAssigner.setCorrectGuess();
            Debug.Log("Correct!");
            bridge1.SetActive(true);
            canvasManager.DisableCanvas();
        }
        else
        {
            characterAssigner.setIncorrectGuess();
            Debug.Log("Incorrect!");
        }
    }
}
