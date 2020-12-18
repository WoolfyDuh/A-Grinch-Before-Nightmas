using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float jumpCount = 2f;
    float jumpForce = 7.5f;
    float moveSpeed = 200f;
    float airSpeed = 250f;
    bool isGrounded = true;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


	public void Move(float input)
	{
        if(isGrounded)
		{
        Vector2 motion = rb.velocity;
        motion.x = input * moveSpeed * Time.deltaTime;
        rb.velocity = motion;
		}
		else
		{
            Vector2 motion = rb.velocity;
            motion.x = input *airSpeed * Time.deltaTime;
            rb.velocity = motion;
        }

    }

    public void Jump()
	{
        if (jumpCount > 0)
		{
            isGrounded = false;
        Vector2 jumpMotion = rb.velocity;
        jumpMotion.y = jumpForce;
        rb.velocity = jumpMotion;
            jumpCount  -= 1f;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.CompareTag("Platform")) { 
            jumpCount = 2f;
            isGrounded = true;
        }
	}
}
