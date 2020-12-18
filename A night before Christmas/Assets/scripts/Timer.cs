﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
   float timeRemaining = 10f;
    bool timerIsRunning = false;
    TextMeshProUGUI tmp;
	private void Awake()
	{
        tmp = gameObject.GetComponent<TextMeshProUGUI>();
	}
	private void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                tmp.text = "TIME LEFT: " + Mathf.Round(timeRemaining);
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                Debug.Log("Time is DONE");
            }
        }
    }

    public void AddTime(float timeToBeAdded)
	{
        timeRemaining += timeToBeAdded;
	}
}