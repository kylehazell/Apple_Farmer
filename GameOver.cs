﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float distance;
    

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z < distance) 
        {
            Debug.Log("Game Over !!!");
        }
    }
}
