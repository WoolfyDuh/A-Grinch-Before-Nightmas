using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float jumpCount = 2f;
    float moveSpeed = 200f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Move(float input)
	{
        Vector2 motion = rb.velocity;
        motion.x = input * moveSpeed * Time.deltaTime;
        rb.velocity = motion;
    }
}
