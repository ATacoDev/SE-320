using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.UI;

public class WordScrambler : MonoBehaviour
{
    public TMP_Text scrambledWord;

    public string[] words = {"apple", "snack", "grape", "melon", "peach"};
    private char[] scrambledChar;

    private string correctWord = "";

    public char[] getScrambledArray()
    {
        return scrambledChar;
    }
    
    public string getCorrectWord()
    {
        return correctWord;
    }

    public void SetScrambledWord()
    {
        string word = words[Random.Range(0, words.Length)];
        correctWord = word;
        scrambledWord.text = ScrambleWord(word);
    }
    
    private string ScrambleWord(string word)
    {
        char[] wordChars = word.ToCharArray();
        for (int i = 0; i < wordChars.Length; i++)
        {
            char temp = wordChars[i];
            int randomIndex = Random.Range(0, wordChars.Length);
            wordChars[i] = wordChars[randomIndex];
            wordChars[randomIndex] = temp;
        }
        scrambledChar = wordChars;
        return new string(wordChars);
    }
    
}