using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayLoseScore : MonoBehaviour
{
    CalculateScore calcScore;
    TextMeshProUGUI tmp;
    
    // Start is called before the first frame update
    void Awake()
    {
        calcScore = GameObject.FindGameObjectWithTag("Score").GetComponent<CalculateScore>();
        tmp = gameObject.GetComponent<TextMeshProUGUI>();
    }
	private void Start()
	{
        tmp.text = "Your Score: " + calcScore.lScore;
	}
}
