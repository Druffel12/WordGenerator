using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    
    private int ArraySelect;
    public int PhraseSelect;
    List<int> NoNos;
    //HOTDAWG
    public string chosenPhrase;
    public Dictionary words;
    SetCategories bools;
	// Use this for initialization

        // selecting wanted arrays
    int arraySelect()
    {
        int retval = -1;
        int start = Random.Range(1, 5);
        
        while(true)
        {
            bool foundNumber = true;
            for (int i = 0; i < NoNos.Count; i++)
            {
                if(start == NoNos[i])
                {
                    foundNumber = false;
                    start++;
                    if(start > 4) { start = 1; }
                    break;
                }
                
            }
            if(foundNumber == true)
            {
                retval = start;
                foundNumber = true;
                break;
            }
            
        }


        return retval;
    }

     public void chooseNewPhrase()
    {
        int ArraySelect = arraySelect();
        PhraseSelect = 0;
        switch (ArraySelect)
        {
            case 1:
                PhraseSelect = Random.Range(0, words.WordBaseGeneral.Length);
                chosenPhrase = words.WordBaseGeneral[PhraseSelect];
                break;
            case 2:
                PhraseSelect = Random.Range(0, words.WordBaseNames.Length);
                chosenPhrase = words.WordBaseNames[PhraseSelect];
                break;
            case 3:
                PhraseSelect = Random.Range(0, words.WordBaseSexual.Length);
                chosenPhrase = words.WordBaseSexual[PhraseSelect];
                break;
            case 4:
                PhraseSelect = Random.Range(0, words.WordBaseReferences.Length);
                chosenPhrase = words.WordBaseReferences[PhraseSelect];
                break;
        }
    }

    //filtering arrays with rand values to find word selected
	void Start ()
    {
        
       // chooseNewPhrase();      
	}

    void Awake()
    {
        NoNos = new List<int>();
        bools = FindObjectOfType<SetCategories>();
        if (!bools.insultsArray) { NoNos.Add(1); }
        if (!bools.namesArray) { NoNos.Add(2); }
        if (!bools.xxxArray) { NoNos.Add(3); }
        if (!bools.memesArray) { NoNos.Add(4); }


    }
}
