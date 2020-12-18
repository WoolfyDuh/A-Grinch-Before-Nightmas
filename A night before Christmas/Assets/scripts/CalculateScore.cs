using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateScore : MonoBehaviour
{
    private static float loseScore  = 0f;
    private static float winScore  = 0f ;

	public float lScore
	{
		get { return loseScore; }
	}
	public float wScore
	{
		get { return winScore; }
	}

	Timer timer;
	Presents present;

	private void Awake()
	{
		timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
		present = GameObject.FindGameObjectWithTag("Player").GetComponent<Presents>();
		ResetScore();
		DontDestroyOnLoad(this);
	}

	public void CalculateLoseScore() => loseScore = Mathf.Round(((present.presentCount + 30) * 75));

	public void CalculateWinScore() => winScore = Mathf.Round(((present.presentCount + 50 + timer.timeRemaining) * 100));

	public void ResetScore()
	{
		loseScore = 0;
		winScore = 0;
	}
}

