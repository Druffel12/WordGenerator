using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    
    private int ArraySelect;
    private int PhraseSelect;
    bool Array1;
    bool Array2;
    bool Array3;
    bool Array4;
    List<int> NoNos;
    //HOTDAWG
	// Use this for initialization

        // selecting wanted arrays
    int arraySelect()
    {
        int retval = -1;
        int start = Random.Range(1, 4);
        
        while(true)
        {
            bool foundNumber = true;
            for (int i =0; i < NoNos.Count; i++)
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

    //filtering arrays with rand values to find word selected
	void Start ()
    {
        NoNos = new List<int>();

        if (Array1) { NoNos.Add(1); }
        if (Array2) { NoNos.Add(2); }
        if (Array3) { NoNos.Add(3); }
        if (Array4) { NoNos.Add(4); }

        int ArraySelect = arraySelect();
        int PhraseSelect = 0;
        switch (ArraySelect)
        {
            case 1:
                PhraseSelect = Random.Range(0, 22);
                break;
            case 2:
                PhraseSelect = Random.Range(0, 8);
                break;
            case 3:
                PhraseSelect = Random.Range(0, 9);
                break;
            case 4:
                PhraseSelect = Random.Range(0, 19);
                break;
        }
	}
}
