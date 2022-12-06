﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay = 7f;

    void DestroyGameObjectAfterTime()
    {
        GameObject.Destroy(gameObject);
    }

    // Update is called once per frame
    void Start()
    {
        Invoke("DestroyGameObjectAfterTime",delay);
    }
}
