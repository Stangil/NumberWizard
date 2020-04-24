using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int guess;
    [SerializeField] Text guessText;

    
    void Start()
    {
        Guess();
    }

    private void Guess()
    {
        //TODO Need to add functionality if min = max
        guess = Random.Range(min , max+1);
        guessText.text = guess.ToString();
    }

    public void ToLow()
    {
        min = guess +1;
        Guess();
    }

    public void ToHigh()
    {
        max = guess -1;
        Guess();
    }

}
