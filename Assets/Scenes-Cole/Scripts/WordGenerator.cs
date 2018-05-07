using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    
    private int ArraySelect;
    private int PhraseSelect;
    
    //HOTDAWG
	// Use this for initialization
	void Start ()
    {
       int ArraySelect = Random.Range(1,4);
        int PhraseSelect = 0;
        switch (ArraySelect)
        {
            case 1:
                PhraseSelect = Random.Range(0, 20);
                break;
            case 2:
                PhraseSelect = Random.Range(0, 8);
                break;
            case 3:
                PhraseSelect = Random.Range(0, 9);
                break;
            case 4:
                PhraseSelect = Random.Range(0, 18);
                break;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
