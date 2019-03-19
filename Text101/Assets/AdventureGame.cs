﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    // SerializeField makes the component available in the inspector
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;


    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        // can use keyword var if the type of the object you're trying to return is already defined
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}


