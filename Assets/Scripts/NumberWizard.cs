using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int guess;
    [SerializeField] TextMeshProUGUI guessText;

    // Use this for initialization
    void Start()
    {
        guessText = GetComponent<TextMeshProUGUI>() ?? gameObject.AddComponent<TextMeshProUGUI>();
        guessText.text = guess.ToString();
    }

    public void ToLow()
    {
        Debug.Log("ToLow");
        min = guess;
        NextGuess();
    }

    public void ToHigh()
    {
        Debug.Log("ToHigh");
        max = guess;
        NextGuess();
    }
     
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log(guess);
        guessText.text = guess.ToString();
    }
}
