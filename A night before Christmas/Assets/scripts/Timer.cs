using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining { get; private set; } = 10f;
    public bool timerIsRunning { get; private set; } = true;
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
            }
        }
    }

	public void AddFiveSeconds()
	{
		timeRemaining += 5f;
	}
}
