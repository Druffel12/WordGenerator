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
      
        switch(ArraySelect)
        {
            case 1:
                int PhraseSelect = Random.Range(0, 20);
            case 2:
                int PhraseSelect = Random.Range(0, 8);
            case 3:
                int PhraseSelect = Random.Range(0, 9);
            case 4:
                int PhraseSelect = Random.Range(0, 18)
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
