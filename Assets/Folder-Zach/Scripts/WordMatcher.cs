using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordMatcher : MonoBehaviour
{
    public WordGenerator generator;

    public AudioSource successSound, failiureSound;
    public GameObject deerPrefab;
    public Vector3 spawnPoint;

    public Text playerInput;
    public Text generatedWord;

    public InputField inputField;

	// Use this for initialization
	void Start ()
    {
        GenerateWord();
	}

    void Awake()
    {
        inputField.text = null;
        inputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (playerInput.text.ToString() == generatedWord.text.ToString())
            {
                CorrectWord();
            }
            else
            {
                IncorrectWord();
            }
        }		
	}

    void CorrectWord()
    {
        Stats.score += 1;
        Stats.time += 2;
        successSound.Play();
        Instantiate(deerPrefab, spawnPoint, Quaternion.identity);
        inputField.text = null;
        inputField.ActivateInputField();
        GenerateWord();
    }

    void IncorrectWord()
    {
        Debug.Log("You suck loser");
        failiureSound.Play();
        inputField.text = null;
        inputField.ActivateInputField();
    }

    void GenerateWord()
    {
        generator.chooseNewPhrase();
        generatedWord.text = generator.chosenPhrase.ToString();
    }
}
