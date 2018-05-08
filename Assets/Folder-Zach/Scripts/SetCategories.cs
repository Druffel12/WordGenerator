using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCategories : MonoBehaviour
{
    public bool insultsArray, namesArray, xxxArray, memesArray;

    public void InsultToggle()
    {
        if (insultsArray == true)
        {
            insultsArray = false;
        }
        else
        {
            insultsArray = true;
        }
    }

    public void NamesToggle()
    {
        if (namesArray == true)
        {
            namesArray = false;
        }
        else
        {
            namesArray = true;
        }
    }

    public void XXXToggle()
    {
        if (xxxArray == true)
        {
            xxxArray = false;
        }
        else
        {
            xxxArray = true;
        }
    }

    public void MemesToggle()
    {
        if (memesArray == true)
        {
            memesArray = false;
        }
        else
        {
            memesArray = true;
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
