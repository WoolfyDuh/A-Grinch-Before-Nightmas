using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    Timer timer;
    CalculateScore calcScore;
	// Start is called before the first frame update
	private void Awake()
	{
		timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
		calcScore = GameObject.FindGameObjectWithTag("Score").GetComponent<CalculateScore>();
	}

	// Update is called once per frame
	void Update()
    {
		CheckForTimerEnd();
    }

	void CheckForTimerEnd()
	{
		if(timer.timerIsRunning == false)
		{
			calcScore.CalculateLoseScore();
			SceneManager.LoadScene("Game Over");
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("Player"))
		{
			calcScore.CalculateWinScore();
			SceneManager.LoadScene("Game Win");
		}
	}
}
