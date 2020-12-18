using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPresentCountToScreen : MonoBehaviour
{
    TextMeshProUGUI tmp;
    Presents present;
    // Start is called before the first frame update
    void Awake()
    {
        tmp = gameObject.GetComponent<TextMeshProUGUI>();
        present = GameObject.FindGameObjectWithTag("Player").GetComponent<Presents>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "PRESENTS: " + present.presentCount;
    }
}
