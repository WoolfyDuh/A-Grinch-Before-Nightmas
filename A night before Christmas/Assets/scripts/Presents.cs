using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presents : MonoBehaviour
{
    public int presentCount { get; private set; }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.CompareTag("Present"))
            presentCount += 1;
	}
}
