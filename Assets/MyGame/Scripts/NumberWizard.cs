using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI guessText;
    public GameObject buttonLower;
    public GameObject buttonHigher;
    public GameObject buttonCorrect;
    public GameObject buttonRestart;

    int min = 1;
    int max = 200;
    int guess;



    // Start is called before the first frame update
    void Start()
    {
        Restart();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();

    }

    public void Lower()
    {
        max = guess - 1;
        NextGuess();
    }
    public void Higher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void Correct()
    {
        buttonHigher.SetActive(false);
        buttonLower.SetActive(false);
        buttonCorrect.SetActive(false);
        buttonRestart.SetActive(true);
    }

    public void Restart()
    {
        min = 1;
        max = 200;
        NextGuess();
        buttonHigher.SetActive(true);
        buttonLower.SetActive(true);
        buttonCorrect.SetActive(true);
        buttonRestart.SetActive(false);
    }
}