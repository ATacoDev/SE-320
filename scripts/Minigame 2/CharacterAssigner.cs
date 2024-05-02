using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterAssigner : MonoBehaviour
{
    public GameObject charBlock1;
    public GameObject charBlock2;
    public GameObject charBlock3;
    public GameObject charBlock4;
    public GameObject charBlock5;
    
    public TMP_Text char1;
    public TMP_Text char2;
    public TMP_Text char3;
    public TMP_Text char4;
    public TMP_Text char5;
    
    public Slot slot1;
    public Slot slot2;
    public Slot slot3;
    public Slot slot4;
    public Slot slot5;
    private Vector2 char1pos;
    private Vector2 char2pos;
    private Vector2 char3pos;
    private Vector2 char4pos;
    private Vector2 char5pos;
    
    [SerializeField] private WordScrambler wordScrambler;
    
    public string correctWord;
    private string guessedWord;
    public GameObject guessedWordText;
    
    private char[] scrambledArray;
    void Start()
    {
        wordScrambler.SetScrambledWord();
        assignCharacters();
        
        correctWord = wordScrambler.getCorrectWord();
        checkCorrect();

        char1pos = charBlock1.GetComponent<RectTransform>().anchoredPosition;
        char2pos = charBlock2.GetComponent<RectTransform>().anchoredPosition;
        char3pos = charBlock3.GetComponent<RectTransform>().anchoredPosition;
        char4pos = charBlock4.GetComponent<RectTransform>().anchoredPosition;
        char5pos = charBlock5.GetComponent<RectTransform>().anchoredPosition;
    }

    public void assignCharacters()
    { 
        scrambledArray = wordScrambler.getScrambledArray();
        char1.text = scrambledArray[0].ToString();
        char2.text = scrambledArray[1].ToString();
        char3.text = scrambledArray[2].ToString();
        char4.text = scrambledArray[3].ToString();
        char5.text = scrambledArray[4].ToString();
    }

    public void checkCorrect()
    {
        Debug.Log("Correct word: " + correctWord);
    }
    
    public void setGuessedWord()
    {
        // check all the slots to see if there's a character assigned to it, if not, don't add
        string word = "";
        // Debug.Log(slot1.GetSlotCharacter());
        if(slot1.GetSlotCharacter() != null)
        {
            word += slot1.GetSlotCharacter();
        }
        if(slot2.GetSlotCharacter() != null)
        {
            word += slot2.GetSlotCharacter();
        }
        if(slot3.GetSlotCharacter() != null)
        {
            word += slot3.GetSlotCharacter();
        }
        if(slot4.GetSlotCharacter() != null)
        {
            word += slot4.GetSlotCharacter();
        }
        if(slot5.GetSlotCharacter() != null)
        {
            word += slot5.GetSlotCharacter();
        }
        guessedWord = word;
        setGuessedWordText();
        resetSlots();
        // Debug.Log("Guessed word: " + guessedWord);
    }

    public void resetSlots()
    {
        slot1.resetSlotCharacter();
        slot2.resetSlotCharacter();
        slot3.resetSlotCharacter();
        slot4.resetSlotCharacter();
        slot5.resetSlotCharacter();
        
        charBlock1.GetComponent<RectTransform>().anchoredPosition = char1pos;
        charBlock2.GetComponent<RectTransform>().anchoredPosition = char2pos;
        charBlock3.GetComponent<RectTransform>().anchoredPosition = char3pos;
        charBlock4.GetComponent<RectTransform>().anchoredPosition = char4pos; 
        charBlock5.GetComponent<RectTransform>().anchoredPosition = char5pos;
    }

    public string getGuessedWord()
    {
        return guessedWord;
    }

    public void setGuessedWordText()
    {
        guessedWordText.GetComponent<TMP_Text>().text = guessedWord;
    }

    public void setCorrectGuess()
    {
        guessedWordText.GetComponent<TMP_Text>().color = Color.green;
    }
    
    public void setIncorrectGuess()
    {
        guessedWordText.GetComponent<TMP_Text>().color = Color.red;
    }
}
