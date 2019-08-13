﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBottomTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1");
        if (other.gameObject.CompareTag("ObjectForGoal"))
        {
            if(Globals.gameState == GameState.RUNNING)
            {
                Globals.gameState = GameState.LOST;
                Debug.Log("2");
            }
        }
    }
}
