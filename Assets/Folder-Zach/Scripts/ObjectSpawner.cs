﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    public void CasingEffect()
    {
        objectPooler.SpawnFromPool("Kobey-Deer", transform.position, Quaternion.identity);
    }
}