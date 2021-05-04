using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI texDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    
    private void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
        if (texDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            texDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        
        if (index < sentences.Length - 1)
        {
            index++;
            texDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            texDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
